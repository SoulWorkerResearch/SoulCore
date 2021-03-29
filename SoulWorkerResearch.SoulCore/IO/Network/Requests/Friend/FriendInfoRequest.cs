using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Info)]
    public readonly struct FriendInfoRequest
    {
        public readonly int CharacterId;

        internal FriendInfoRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
