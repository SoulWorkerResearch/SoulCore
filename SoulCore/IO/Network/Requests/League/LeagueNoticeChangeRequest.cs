using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.NoticeChange)]
    public readonly struct LeagueNoticeChangeRequest
    {
        internal LeagueNoticeChangeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}