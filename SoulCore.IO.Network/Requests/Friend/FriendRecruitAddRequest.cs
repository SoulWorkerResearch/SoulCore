using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.RecruitAdd)]
    public readonly struct FriendRecruitAddRequest
    {
        public FriendRecruitAddRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}