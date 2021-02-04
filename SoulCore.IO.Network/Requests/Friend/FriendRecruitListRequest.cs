using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.RecruitList)]
    public readonly struct FriendRecruitListRequest
    {
        public FriendRecruitListRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}