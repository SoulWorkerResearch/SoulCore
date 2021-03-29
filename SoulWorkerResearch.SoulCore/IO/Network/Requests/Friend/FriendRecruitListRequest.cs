using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.Types;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.RecruitList)]
    public readonly struct FriendRecruitListRequest
    {
        public readonly int CharacterId;
        public readonly byte LevelMin;
        public readonly byte LevelMax;
        public readonly Class Class;

        internal FriendRecruitListRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            LevelMin = br.ReadByte();
            LevelMax = br.ReadByte();
            Class = br.ReadClass();
        }
    }
}
