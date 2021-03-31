using System;
using System.Net;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    public abstract class BaseServer<TServer, TSession> : IBaseServer
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal readonly InternalServer<TServer, TSession> InternalServer;

        public bool Start() => InternalServer.Start();

        public bool Stop() => InternalServer.Stop();

        protected BaseServer(IServiceProvider services, string ip, ushort port) =>
            InternalServer = new((TServer)this, services, new(IPAddress.Parse(ip), port));
    }
}