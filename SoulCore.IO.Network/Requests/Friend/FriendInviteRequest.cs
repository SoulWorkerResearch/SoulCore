using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Invite)]
    public readonly struct FriendInviteRequest
    {
        public readonly string CharacterName;

        internal FriendInviteRequest(BinaryReader br) => CharacterName = br.ReadByteLengthUnicodeString();
    }
}