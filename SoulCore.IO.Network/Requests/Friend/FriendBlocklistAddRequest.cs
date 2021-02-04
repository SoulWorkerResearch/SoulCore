using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.BlocklistAdd)]
    public readonly struct FriendBlocklistAddRequest
    {
        public FriendBlocklistAddRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}