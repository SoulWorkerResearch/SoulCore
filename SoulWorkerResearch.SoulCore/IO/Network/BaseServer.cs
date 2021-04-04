using System;
using System.Collections.Generic;
using System.Net;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    public abstract class BaseServer<TServer, TSession> : IBaseServer
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        private readonly IReadOnlyList<byte> _packetKeyTable = new byte[]
        {
            0xEE, 0x1B, 0xDE, 0xA6, 0x46, 0xE9, 0x2A, 0xDB,
            0x97, 0x67, 0x9C, 0x02, 0x3C, 0xCE, 0x9A
        };

        internal readonly InternalServer<TServer, TSession> InternalServer;

        public virtual void OnPacketExchange(Span<byte> encryptedBuffer)
        {
            for (int i = 0; i < encryptedBuffer.Length; ++i)
            {
                encryptedBuffer[i] ^= _packetKeyTable[i % _packetKeyTable.Count];
            }
        }

        internal byte[] GetPackedPacket(PacketWriter writer)
        {
            byte[] response = writer.GetBuffer();
            OnPacketExchange(response.AsSpan(CommonDefines.PacketHeaderSize, (int)writer.BaseStream.Length - CommonDefines.PacketHeaderSize));

            return response;
        }

        public bool Start() => InternalServer.Start();

        public bool Stop() => InternalServer.Stop();

        protected BaseServer(IServiceProvider services, string ip, ushort port) =>
            InternalServer = new((TServer)this, services, new(IPAddress.Parse(ip), port));
    }
}