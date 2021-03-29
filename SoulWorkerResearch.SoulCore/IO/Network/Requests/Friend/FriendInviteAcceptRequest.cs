using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.InviteAccept)]
    public readonly struct FriendInviteAcceptRequest
    {
        public readonly int CharacterId;
        public readonly int TargetCharacterId;
        public readonly string TargetCharacterName;
        public readonly bool Accept;

        internal FriendInviteAcceptRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            TargetCharacterId = br.ReadInt32();
            TargetCharacterName = br.ReadCharacterLengthUnicodeString();
            Accept = br.ReadBoolean();
        }
    }
}
