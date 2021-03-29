using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.ChangeMaster)]
    public readonly struct PartyChangeMasterRequest
    {
        public readonly int CharacterId;

        internal PartyChangeMasterRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
