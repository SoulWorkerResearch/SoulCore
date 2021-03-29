using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.BlocklistAdd)]
    public readonly struct FriendBlocklistAddRequest
    {
        public readonly string CharacterName;

        internal FriendBlocklistAddRequest(BinaryReader br) => CharacterName = br.ReadCharacterLengthUnicodeString();
    }
}
