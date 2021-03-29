using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Invite)]
    public readonly struct FriendInviteRequest
    {
        public readonly string CharacterName;

        internal FriendInviteRequest(BinaryReader br) => CharacterName = br.ReadCharacterLengthUnicodeString();
    }
}
