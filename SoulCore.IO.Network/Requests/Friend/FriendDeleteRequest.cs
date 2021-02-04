using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Delete)]
    public readonly struct FriendDeleteRequest
    {
        public readonly int CharacterId;
        public readonly bool OnMessage;

        internal FriendDeleteRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            OnMessage = br.ReadBoolean();
        }
    }
}