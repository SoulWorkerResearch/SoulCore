using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Responses
{
    [Response(CategoryCommand.World, WorldCommand.OutInfoPc)]
    public readonly struct WorldOutInfoPcResponse
    {
        public readonly int CharacterId { get; init; }

        internal WorldOutInfoPcResponse(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}