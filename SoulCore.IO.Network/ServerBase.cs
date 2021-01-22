using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetCoreServer;
using System;
using System.Net;

namespace SoulCore.IO.Network
{
    internal sealed class InternalServer<TSession> : TcpServer where TSession : SessionBase
    {
        private readonly ILogger<InternalServer<TSession>> _logger;
        private readonly IServiceProvider _services;

        public override bool Start()
        {
            _logger.LogDebug($"Listen on {Endpoint}");

            return base.Start();
        }

        internal InternalServer(IServiceProvider services, IPEndPoint endpont) : base(endpont)
        {
            _logger = services.GetRequiredService<ILogger<InternalServer<TSession>>>();
            _services = services;
        }

        protected override TcpSession CreateSession() => _services.GetRequiredService<TSession>().InternalSession;
    }

    public abstract class ServerBase<TSession> where TSession : SessionBase
    {
        internal InternalServer<TSession> InternalServer { get; }

        public bool Start() => InternalServer.Start();

        public bool Stop() => InternalServer.Stop();

        protected ServerBase(IServiceProvider services, IConfiguration configuration) =>
            InternalServer = new(services, GetIPEndPoint(configuration));

        private static IPEndPoint GetIPEndPoint(IConfiguration configuration) =>
            IPEndPoint.Parse($"{configuration["Ip"]}:{configuration["Port"]}");
    }
}