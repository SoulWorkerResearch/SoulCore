﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    [Request(CategoryCommand.Friend, FriendCommand.BlocklistDelete)]
    public readonly struct FriendBlocklistDeleteRequest
    {
        public FriendBlocklistDeleteRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}