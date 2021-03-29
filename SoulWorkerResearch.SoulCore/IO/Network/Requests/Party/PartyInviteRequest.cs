using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.Invite)]
    public readonly struct PartyInviteRequest
    {
        public readonly string CharacterName;
        public readonly string MasterCharacterName;
        public readonly int CharacterId;
        public readonly int MasterId;
        public readonly int ServerId;
        public readonly int Result;

        internal PartyInviteRequest(BinaryReader br)
        {
            CharacterName = br.ReadByteLengthUnicodeString();
            MasterCharacterName = br.ReadByteLengthUnicodeString();
            CharacterId = br.ReadInt32();
            MasterId = br.ReadInt32();
            ServerId = br.ReadInt32();
            Result = br.ReadInt32();
        }
    }
}
