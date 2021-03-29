using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Channel
{
    [Request(CategoryCommand.Channel, ChannelCommand.Change)]
    public readonly struct ChannelChangeRequest
    {
        public readonly ushort ChannelId;

        internal ChannelChangeRequest(BinaryReader br) => ChannelId = br.ReadUInt16();
    }
}
