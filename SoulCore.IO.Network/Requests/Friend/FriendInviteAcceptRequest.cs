using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
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
            TargetCharacterName = br.ReadByteLengthUnicodeString();
            Accept = br.ReadBoolean();
        }
    }
}