using Microsoft.Extensions.DependencyInjection;
using NetCoreServer;
using System;
using System.Net;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    internal sealed class InternalServer<TServer, TSession> : TcpServer
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal readonly IServiceProvider Services;
        internal readonly TServer Server;

        internal InternalServer(TServer server, IServiceProvider services, IPEndPoint endpont) : base(endpont)
        {
            Services = services;
            Server = server;
        }

        protected override TcpSession CreateSession() => Services.GetRequiredService<TSession>().InternalSession;
    }
}