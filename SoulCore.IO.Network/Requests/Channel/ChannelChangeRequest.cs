using System.IO;

namespace SoulCore.IO.Network.Requests.Channel
{
    public readonly struct ChannelChangeRequest
    {
        public readonly ushort ChannelId;

        internal ChannelChangeRequest(BinaryReader br)
        {
            ChannelId = br.ReadUInt16();
        }
    }
}