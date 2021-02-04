using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.RecommandList)]
    public readonly struct FriendRecommandFriendListRequest
    {
        public FriendRecommandFriendListRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}