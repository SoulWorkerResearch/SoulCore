using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Info)]
    public readonly struct FriendInfoRequest
    {
        public readonly int CharacterId;

        internal FriendInfoRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
        }
    }
}