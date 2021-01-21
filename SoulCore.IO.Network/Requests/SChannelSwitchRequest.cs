using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct SChannelSwitchRequest
    {
        public ushort Id { get; }

        public SChannelSwitchRequest(BinaryReader br) =>
            Id = br.ReadUInt16();
    }
}
