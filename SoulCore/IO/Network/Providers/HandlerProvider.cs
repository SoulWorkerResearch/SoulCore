using Microsoft.Extensions.Logging;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Exceptions;
using SoulCore.IO.Network.Permissions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace SoulCore.IO.Network.Providers
{
    internal sealed class HandlerProvider<TServer, TSession> : List<HandlerProvider<TServer, TSession>.Handler>
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal sealed record Handler
        {
            internal delegate ValueTask MethodInfo(TSession session, BinaryReader br);

            internal readonly HandlerPermission Permission;
            internal readonly MethodInfo Method;

            internal Handler(MethodInfo method, HandlerPermission permission)
            {
                Method = method;
                Permission = permission;
            }
        }

        internal HandlerProvider(Type serverType, ILogger logger) : base(CreateHandlers(serverType, logger))
        {
        }

        private static ValueTask Dummy(TSession _1, BinaryReader _2)
        {
            return ValueTask.CompletedTask;
        }

        private static IEnumerable<Handler> CreateHandlers(Type serverType, ILogger logger)
        {
            ServerAttribute? serviceAttribute = serverType.GetCustomAttribute<ServerAttribute>();

            if (serviceAttribute is null)
            {
                throw new IONetworkException("Use ServiceTypeAttribute on service class");
            }

            IEnumerable<MethodInfo> methods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
                .Where(type => type.IsDefined(typeof(HandlerAttribute)));

            Handler[] handlers = Enumerable.Repeat(new Handler(Dummy, HandlerPermission.None), GetMaxHandlersCount()).ToArray();

            foreach (MethodInfo method in methods)
            {
                HandlerAttribute? methodAttribute = method.GetCustomAttribute<HandlerAttribute>();
                if (methodAttribute is null || methodAttribute.Service != serviceAttribute.Type || methodAttribute.ServerType != serverType)
                {
                    continue;
                }

                ushort opcode = (ushort)((byte)methodAttribute.Category + (methodAttribute.Command << 8));
                logger.LogDebug($"Used SYNC EVENT 0x{opcode:X4}/{methodAttribute.Category}/{methodAttribute.Command} ({method.Name}) invoker on {method.DeclaringType?.FullName ?? ""}.");

                Handler.MethodInfo handlerMethod = CreateHandlerMethod(method);
                handlers[opcode] = new(handlerMethod, methodAttribute.Permission);
            }

            return handlers;
        }

        private static Handler.MethodInfo CreateHandlerMethod(MethodInfo method)
        {
            ParameterExpression session = Expression.Parameter(typeof(TSession), "Session");
            ParameterExpression br = Expression.Parameter(typeof(BinaryReader), "BinaryReader");

            IEnumerable<Expression> arguments = method.GetParameters().Select(param =>
            {
                if (param.IsIn)
                {
                    throw new IONetworkException(@"In\Out\In arguments not supported");
                }

                if (param.ParameterType is null)
                {
                    throw new IONetworkException("ParameterType is null");
                }

                // Session typed parameter
                if (param.ParameterType == typeof(TSession) || param.ParameterType.BaseType == typeof(TSession))
                {
                    return Expression.Convert(session, param.ParameterType) as Expression;
                }

                // Packet structure parameter
                if (param.ParameterType.IsDefined(typeof(RequestAttribute)))
                {
                    const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
                    ConstructorInfo? constructor = param.ParameterType.GetConstructor(flags, null, new[] { typeof(BinaryReader) }, null);
                    if (constructor is null)
                    {
                        throw new IONetworkException($"{param.ParameterType} Constructor is null");
                    }

                    FieldInfo[] fields = param.ParameterType.GetFields();
                    if (fields.Length == 0)
                    {
                        throw new IONetworkException($"{param.ParameterType} This packet no have content or not implemented");
                    }

                    return Expression.New(constructor, br);
                }

                throw new IONetworkException($"{param.ParameterType} Bad argument type");
            });

            MethodCallExpression caller = Expression.Call(null, method, arguments.ToArray());
            return Expression.Lambda<Handler.MethodInfo>(caller, session, br).Compile();
        }

        private static int GetMaxHandlersCount() => Convert.ToInt32(CommonDefines.PacketOpcodeType
            .GetField("MaxValue", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?
            .GetRawConstantValue());
    }
}