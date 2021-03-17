using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Channel
{
    [Request(CategoryCommand.Channel, ChannelCommand.Change)]
    public readonly struct ChannelChangeRequest
    {
        public readonly ushort ChannelId;

        internal ChannelChangeRequest(BinaryReader br) => ChannelId = br.ReadUInt16();
    }
}