using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.Accept)]
    public readonly struct PartyAcceptRequest
    {
        public readonly int CharacterId;

        internal PartyAcceptRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
