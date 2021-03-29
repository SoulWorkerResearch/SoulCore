using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.KickOut)]
    public readonly struct PartyKickOutRequest
    {
        public readonly int CharacterId;

        internal PartyKickOutRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
