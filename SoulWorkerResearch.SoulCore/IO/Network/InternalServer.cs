using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetCoreServer;
using SoulWorkerResearch.SoulCore.IO.Network.Providers;
using System;
using System.Net;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    internal sealed class InternalServer<TServer, TSession> : TcpServer
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal readonly HandlerProvider<TServer, TSession> Handlers;
        internal readonly IServiceProvider Services;
        internal readonly TServer Server;

        internal InternalServer(Type serverType, TServer server, IServiceProvider services, IPEndPoint endpont) : base(endpont)
        {
            Services = services;
            Server = server;

            ILogger<InternalServer<TServer, TSession>> logger = services.GetRequiredService<ILogger<InternalServer<TServer, TSession>>>();
            Handlers = new(serverType, logger);
        }

        protected override TcpSession CreateSession() => Services.GetRequiredService<TSession>().InternalSession;
    }
}
