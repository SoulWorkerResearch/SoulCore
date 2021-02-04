using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.RecruitInfo)]
    public readonly struct FriendRecruitInfoRequest
    {
        public FriendRecruitInfoRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}