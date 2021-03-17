﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.RecruitNotice)]
    public readonly struct LeagueRecruitNoticeRequest
    {
        internal LeagueRecruitNoticeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}