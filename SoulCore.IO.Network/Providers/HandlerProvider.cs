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
            SyncServerAttribute? serviceAttribute = serverType.GetCustomAttribute<SyncServerAttribute>();

            if (serviceAttribute is null)
            {
                throw new IONetworkException("Use ServiceTypeAttribute on service class");
            }

            IEnumerable<MethodInfo> methods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
                .Where(type => type.IsDefined(typeof(SyncHandlerAttribute)));

            Handler[] handlers = Enumerable.Repeat(new Handler(Dummy, HandlerPermission.None), GetMaxHandlersCount()).ToArray();

            foreach (MethodInfo method in methods)
            {
                SyncHandlerAttribute? methodAttribute = method.GetCustomAttribute<SyncHandlerAttribute>();
                if (methodAttribute is null || methodAttribute.Service != serviceAttribute.Type || methodAttribute.ServerType != serverType)
                {
                    continue;
                }

                Handler.MethodInfo handlerMethod = CreateHandlerMethod(method);
                ushort opcode = (ushort)((byte)methodAttribute.Category + (methodAttribute.Command << 8));

                handlers[opcode] = new(handlerMethod, methodAttribute.Permission);

                logger.LogDebug($"Used SYNC EVENT 0x{opcode:X4}/{methodAttribute.Category}/{methodAttribute.Command} ({method.Name}) invoker on {method.DeclaringType?.FullName ?? ""}.");
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
                    ConstructorInfo? constructor = param.ParameterType.GetConstructor(new[] { typeof(BinaryReader) });
                    if (constructor is null)
                    {
                        throw new IONetworkException("Constructor is null");
                    }

                    PropertyInfo[] props = param.ParameterType.GetProperties();
                    if (props.Length == 0)
                    {
                        throw new IONetworkException("This packet no have content. Don't use request structure");
                    }

                    return Expression.New(constructor, br);
                }

                throw new IONetworkException("Bad argument type");
            });

            MethodCallExpression caller = Expression.Call(null, method, arguments.ToArray());
            return Expression.Lambda<Handler.MethodInfo>(caller, session, br).Compile();
        }

        private static int GetMaxHandlersCount() => Convert.ToInt32(Defines.PacketOpcodeType
            .GetField("MaxValue", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?
            .GetRawConstantValue());
    }
}