using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Find)]
    public readonly struct FriendFindRequest
    {
        public FriendFindRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}