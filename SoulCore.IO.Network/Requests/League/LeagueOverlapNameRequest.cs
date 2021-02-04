using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.OverlapName)]
    public readonly struct LeagueOverlapNameRequest
    {
        internal LeagueOverlapNameRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}