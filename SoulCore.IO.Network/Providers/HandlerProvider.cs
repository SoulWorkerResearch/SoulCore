using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Exceptions;
using SoulCore.IO.Network.Permissions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SoulCore.IO.Network.Providers
{
    public class HandlerProvider<TServer, TSession> : List<HandlerProvider<TServer, TSession>.Entity>
        where TServer : ServerBase<TServer, TSession>
        where TSession : SessionBase<TServer, TSession>
    {
        public sealed record Entity
        {
            public delegate void MethodInfo(TSession session, BinaryReader br);

            public HandlerPermission Permission { get; }
            public MethodInfo Method { get; }

            public Entity(HandlerPermission permission, MethodInfo method)
            {
                Permission = permission;
                Method = method;
            }
        }

        public HandlerProvider(IServiceProvider service, ILogger<HandlerProvider<TServer, TSession>> logger) :
            base(GetHandlers(service, logger))
        {
        }

        private static void Dummy(SessionBase<TServer, TSession> session, BinaryReader _)
        {
#if !DEBUG
            session.InternalSession.Disconnect();
#endif // !DEBUG
        }

        private static List<Entity> GetHandlers(IServiceProvider service, ILogger logger)
        {
            IEnumerable<MethodInfo> methods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
                .Where(type => type.IsDefined(typeof(HandlerAttribute)));

            List<Entity> handlers = Enumerable.Repeat(new Entity(HandlerPermission.None, Dummy), GetMaxHandlersCount()).ToList();

            Dictionary<Type, object?> instances = new(methods.Count());

            foreach (MethodInfo method in methods)
            {
                object? instance = null;
                if (!method.IsStatic)
                {
                    if (method.DeclaringType is null)
                        throw new NetworkException("Cannot determe class type");

                    if (!instances.TryGetValue(method.DeclaringType, out instance))
                    {
                        if (method.DeclaringType.IsAbstract && method.DeclaringType.IsSealed)
                            throw new NetworkException();

                        instance = service.GetRequiredService(method.DeclaringType);
                        instances.Add(method.DeclaringType, instance);
                    }
                }

                HandlerAttribute? attribute = method.GetCustomAttribute<HandlerAttribute>();
                if (attribute is null)
                    throw new NetworkException("Handler attribute not found");

                Entity.MethodInfo handlerMethod = CreateHandlerMethod(instance, service, method);
                handlers[(byte)attribute.Category + (attribute.Command << 8)] = new(attribute.Permission, handlerMethod);

                logger.LogDebug($"Used SoulWorker EVENT [{attribute.Category:X2}:0x{attribute.Command:X2}] invoker on {method.DeclaringType!.FullName}.{method.Name}.");
            }

            return handlers;
        }

        private static Entity.MethodInfo CreateHandlerMethod(object? instance, IServiceProvider service, MethodInfo method)
        {
            ParameterExpression session = Expression.Parameter(typeof(TSession), "Session");
            ParameterExpression br = Expression.Parameter(typeof(BinaryReader), "BinaryReader");

            Expression[] arguments = method.GetParameters().Select(param =>
            {
                if (param.IsIn)
                    throw new NetworkException("In arguments not supported");

                if (param.ParameterType is null)
                    throw new NetworkException("ParameterType is null");

                // Session typed parameter
                if (param.ParameterType == typeof(TSession) || param.ParameterType.BaseType == typeof(TSession))
                    return Expression.Convert(session, param.ParameterType) as Expression;

                // Packet structure parameter
                if (param.ParameterType.IsDefined(typeof(RequestAttribute)))
                {
                    ConstructorInfo? constructor = param.ParameterType.GetConstructor(new[] { typeof(BinaryReader) });
                    if (constructor is null)
                        throw new NetworkException("constructor is null");

                    return Expression.New(constructor, br);
                }

                // Otherwise, get parameter from service collection
                ConstantExpression innerService = Expression.Constant(service);

                MethodInfo? methodGetRequiredService = typeof(ServiceProviderServiceExtensions).GetMethod("GetRequiredService", new[] { typeof(IServiceProvider), typeof(Type) });
                Debug.Assert(methodGetRequiredService is not null);

                MethodCallExpression call = Expression.Call(methodGetRequiredService, innerService, Expression.Constant(param.ParameterType));
                return Expression.Convert(call, param.ParameterType);
            }).ToArray();

            MethodCallExpression caller = Expression.Call(instance is null ? null : Expression.Constant(instance), method, arguments);
            return Expression.Lambda<Entity.MethodInfo>(caller, session, br).Compile();
        }

        private static int GetMaxHandlersCount() => Convert.ToInt32(Defines.PacketOpcodeType
            .GetField("MaxValue", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?
            .GetRawConstantValue());
    }
}