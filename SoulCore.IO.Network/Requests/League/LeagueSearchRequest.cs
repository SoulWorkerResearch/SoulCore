using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Search)]
    public readonly struct LeagueSearchRequest
    {
        internal LeagueSearchRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}