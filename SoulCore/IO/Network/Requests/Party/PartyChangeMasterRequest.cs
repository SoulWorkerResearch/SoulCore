using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.ChangeMaster)]
    public readonly struct PartyChangeMasterRequest
    {
        public readonly int CharacterId;

        internal PartyChangeMasterRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}