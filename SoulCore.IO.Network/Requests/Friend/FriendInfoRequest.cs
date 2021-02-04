using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Info)]
    public readonly struct FriendInfoRequest
    {
        public FriendInfoRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}