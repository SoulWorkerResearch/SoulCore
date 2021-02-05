using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.PacketSharedStructure;

namespace SoulCore.IO.Network.Responses
{
    [Response(CategoryCommand.World, WorldCommand.InInfoPc)]
    public readonly struct WorldInInfoPcResponse
    {
        public readonly CharacterExPacketSharedStructure Character { get; init; }
    }
}