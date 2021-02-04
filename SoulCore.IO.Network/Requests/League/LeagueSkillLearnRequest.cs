﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.SkillLearn)]
    public readonly struct LeagueSkillLearnRequest
    {
        internal LeagueSkillLearnRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}