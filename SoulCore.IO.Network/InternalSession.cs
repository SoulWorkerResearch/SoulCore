using NetCoreServer;
using SoulCore.IO.Network.Utils;
using System.IO;

namespace SoulCore.IO.Network
{
    internal sealed class InternalSession<TServer, TSession> : TcpSession
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal readonly TSession Session;

        protected override void OnDisconnected() => Session.OnDisconnected();

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            using MemoryStream ms = new(buffer, (int)offset, (int)size, false);
            using BinaryReader br = new(ms);

            try
            {
                do
                {
                    PacketHeader packet = new(br);
                    PacketUtils.Exchange(ms.GetBuffer(), (int)ms.Position, (int)ms.Position - (packet.Size + Defines.PacketHeaderSize));

                    Session.ProcessPacket(br);
                } while (br.BaseStream.Position < br.BaseStream.Length);
            }
            catch
            {
#if !DEBUG
                Disconnect();
#endif
            }
        }

        internal InternalSession(InternalServer<TServer, TSession> server, TSession session) : base(server) => Session = session;
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8