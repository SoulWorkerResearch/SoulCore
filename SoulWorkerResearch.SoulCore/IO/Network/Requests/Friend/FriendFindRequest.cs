using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Find)]
    public readonly struct FriendFindRequest
    {
        public readonly string CharacterName;

        internal FriendFindRequest(BinaryReader br) => CharacterName = br.ReadCharacterLengthUnicodeString();
    }
}
