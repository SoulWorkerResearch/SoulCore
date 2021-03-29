using NetCoreServer;
using SoulWorkerResearch.SoulCore.IO.Network.Utils;
using System.IO;
using System.Threading.Tasks;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    internal sealed class InternalSession<TServer, TSession> : TcpSession
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal readonly TSession Session;

        protected override void OnDisconnected() => Session.OnDisconnected();

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            Task task = Task.Run(async () =>
            {
                await using MemoryStream ms = new(buffer, (int)offset, (int)size, false);
                using BinaryReader br = new(ms);

                try
                {
                    do
                    {
                        PacketHeader packet = new(br);
                        PacketUtils.Exchange(ms.GetBuffer(), (int)ms.Position, (int)ms.Position - (packet.Size + CommonDefines.PacketHeaderSize));

                        await Session.ProcessPacket(br).ConfigureAwait(false);
                    } while (br.BaseStream.Position < br.BaseStream.Length);
                }
                catch
                {
#if !DEBUG
                    Disconnect();
#endif
                }
            });

            task.Wait();
        }

        internal InternalSession(InternalServer<TServer, TSession> server, TSession session) : base(server) => Session = session;
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8
