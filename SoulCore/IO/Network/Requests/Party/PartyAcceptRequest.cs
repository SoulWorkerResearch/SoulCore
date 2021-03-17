using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.Accept)]
    public readonly struct PartyAcceptRequest
    {
        public readonly int CharacterId;

        internal PartyAcceptRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}