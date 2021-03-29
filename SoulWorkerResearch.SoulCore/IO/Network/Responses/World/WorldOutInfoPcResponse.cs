using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    [Response(CategoryCommand.World, WorldCommand.OutInfoPc)]
    public readonly struct WorldOutInfoPcResponse
    {
        public readonly int CharacterId { get; init; }

        internal WorldOutInfoPcResponse(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
