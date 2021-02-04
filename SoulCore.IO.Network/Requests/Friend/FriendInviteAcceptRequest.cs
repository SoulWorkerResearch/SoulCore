using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.InviteAccept)]
    public readonly struct FriendInviteAcceptRequest
    {
        public FriendInviteAcceptRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}