using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.BlocklistAdd)]
    public readonly struct FriendBlocklistAddRequest
    {
        public readonly string CharacterName;

        internal FriendBlocklistAddRequest(BinaryReader br) => CharacterName = br.ReadByteLengthUnicodeString();
    }
}