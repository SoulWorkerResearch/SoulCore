﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.NameChange)]
    public readonly struct LeagueNameChangeRequest
    {
        internal LeagueNameChangeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}