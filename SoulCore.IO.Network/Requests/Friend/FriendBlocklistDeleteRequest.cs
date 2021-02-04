using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.BlocklistDelete)]
    public readonly struct FriendBlocklistDeleteRequest
    {
        public readonly string CharacterName;

        internal FriendBlocklistDeleteRequest(BinaryReader br)
        {
            CharacterName = br.ReadByteLengthUnicodeString();
        }
    }
}