using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.RecruitDelete)]
    public readonly struct FriendRecruitDeleteRequest
    {
        public FriendRecruitDeleteRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}