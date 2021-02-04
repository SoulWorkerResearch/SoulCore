using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.List)]
    public readonly struct LeagueListRequest
    {
        internal LeagueListRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}