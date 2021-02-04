using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.Invite)]
    public readonly struct FriendInviteRequest
    {
        public FriendInviteRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}