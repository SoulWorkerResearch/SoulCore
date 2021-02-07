using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Exceptions;
using SoulCore.IO.Network.Permissions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SoulCore.IO.Network.Providers
{
    internal class HandlerProvider<TServer, TSession> : List<HandlerProvider<TServer, TSession>.Handler>
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal sealed record Handler
        {
            internal delegate void MethodInfo(TSession session, BinaryReader br);

            internal readonly HandlerPermission Permission;
            internal readonly MethodInfo Method;

            internal Handler(HandlerPermission permission, MethodInfo method)
            {
                Permission = permission;
                Method = method;
            }
        }

        internal HandlerProvider() : base(GetHandlers())
        {
        }

        private static void Dummy(BaseSession<TServer, TSession> _1, BinaryReader _2)
        {
        }

        private static IEnumerable<Handler> GetHandlers()
        {
            IEnumerable<MethodInfo> methods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
                .Where(type => type.IsDefined(typeof(HandlerAttribute)));

            Handler[] handlers = Enumerable.Repeat(new Handler(HandlerPermission.None, Dummy), GetMaxHandlersCount()).ToArray();

            Dictionary<Type, object?> instances = new(methods.Count());

            foreach (MethodInfo method in methods)
            {
                HandlerAttribute? attribute = method.GetCustomAttribute<HandlerAttribute>();
                if (attribute is null)
                {
                    throw new NetworkException("Handler attribute not found");
                }

                Handler.MethodInfo handlerMethod = CreateHandlerMethod(method);
                handlers[(byte)attribute.Category + (attribute.Command << 8)] = new(attribute.Permission, handlerMethod);
            }

            return handlers;
        }

        private static Handler.MethodInfo CreateHandlerMethod(MethodInfo method)
        {
            ParameterExpression session = Expression.Parameter(typeof(TSession), "Session");
            ParameterExpression br = Expression.Parameter(typeof(BinaryReader), "BinaryReader");

            Expression[] arguments = method.GetParameters().Select(param =>
            {
                if (param.IsIn)
                {
                    throw new NetworkException("In arguments not supported");
                }

                if (param.ParameterType is null)
                {
                    throw new NetworkException("ParameterType is null");
                }

                // Session typed parameter
                if (param.ParameterType == typeof(TSession) || param.ParameterType.BaseType == typeof(TSession))
                {
                    return Expression.Convert(session, param.ParameterType) as Expression;
                }

                // Packet structure parameter
                if (param.ParameterType.IsDefined(typeof(RequestAttribute)))
                {
                    ConstructorInfo? constructor = param.ParameterType.GetConstructor(new[] { typeof(BinaryReader) });
                    if (constructor is null)
                    {
                        throw new NetworkException("Constructor is null");
                    }

                    return Expression.New(constructor, br);
                }

                throw new NetworkException("Bad argument type");
            }).ToArray();

            MethodCallExpression caller = Expression.Call(null, method, arguments);
            return Expression.Lambda<Handler.MethodInfo>(caller, session, br).Compile();
        }

        private static int GetMaxHandlersCount() => Convert.ToInt32(Defines.PacketOpcodeType
            .GetField("MaxValue", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?
            .GetRawConstantValue());
    }
}