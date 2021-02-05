using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.PacketSharedStructure;
using SoulCore.IO.Network.Responses.Shared;

namespace SoulCore.IO.Network.Responses
{
    [Response(CategoryCommand.World, WorldCommand.InInfoPc)]
    public readonly struct WorldInInfoPcResponse
    {
        public readonly CharacterPacketSharedStructure Character { get; init; }
        public readonly PlaceShared Place { get; init; }
    }
}