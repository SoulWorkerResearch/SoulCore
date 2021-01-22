using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetCoreServer;
using System;
using System.Net;

namespace SoulCore.IO.Network
{
    internal sealed class InternalServer<TServer, TSession> : TcpServer
        where TServer : ServerBase<TServer, TSession>
        where TSession : SessionBase<TServer, TSession>
    {
        private readonly ILogger<InternalServer<TServer, TSession>> _logger;
        private readonly IServiceProvider _services;

        internal TServer BaseServer { get; }

        public override bool Start()
        {
            _logger.LogDebug($"Listen on {Endpoint}");

            return base.Start();
        }

        internal InternalServer(TServer baseServer, IServiceProvider services, IPEndPoint endpont) : base(endpont)
        {
            BaseServer = baseServer;
            _logger = services.GetRequiredService<ILogger<InternalServer<TServer, TSession>>>();
            _services = services;
        }

        protected override TcpSession CreateSession() => _services.GetRequiredService<TSession>().InternalSession;
    }

    public abstract class ServerBase<TServer, TSession>
        where TServer : ServerBase<TServer, TSession>
        where TSession : SessionBase<TServer, TSession>
    {
        internal InternalServer<TServer, TSession> InternalServer { get; }

        public bool Start() => InternalServer.Start();

        public bool Stop() => InternalServer.Stop();

        protected ServerBase(IServiceProvider services, IConfiguration configuration) =>
            InternalServer = new((TServer)this, services, GetIPEndPoint(configuration));

        private static IPEndPoint GetIPEndPoint(IConfiguration configuration) =>
            IPEndPoint.Parse($"{configuration["Ip"]}:{configuration["Port"]}");
    }
}