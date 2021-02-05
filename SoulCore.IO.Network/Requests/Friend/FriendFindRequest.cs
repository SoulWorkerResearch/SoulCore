using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Find)]
    public readonly struct FriendFindRequest
    {
        public readonly string CharacterName;

        internal FriendFindRequest(BinaryReader br) => CharacterName = br.ReadByteLengthUnicodeString();
    }
}