using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.IO.Network.PacketSharedStructure;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    [Response(CategoryCommand.World, WorldCommand.InInfoPc)]
    public readonly struct WorldInInfoPcResponse
    {
        public readonly CharacterExPacketSharedStructure Character { get; init; }
    }
}
