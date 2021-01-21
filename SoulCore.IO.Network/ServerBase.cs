using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetCoreServer;
using System;
using System.Net;

namespace SoulCore.IO.Network
{
    public abstract class ServerBase : TcpServer
    {
        private readonly ILogger<ServerBase> _logger;

        protected readonly IServiceProvider Services;

        protected ServerBase(IServiceProvider services, IConfiguration configuration) :
            base(IPEndPoint.Parse($"{configuration["Ip"]}:{configuration["Port"]}"))
        {
            _logger = services.GetRequiredService<ILogger<ServerBase>>();
            Services = services;
        }

        public override bool Start()
        {
            _logger.LogDebug($"Listen: {Endpoint}");

            return base.Start();
        }
    }
}