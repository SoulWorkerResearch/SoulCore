using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.BlocklistDelete)]
    public readonly struct FriendBlocklistDeleteRequest
    {
        public readonly string CharacterName;

        internal FriendBlocklistDeleteRequest(BinaryReader br) => CharacterName = br.ReadCharacterLengthUnicodeString();
    }
}
