using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
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
