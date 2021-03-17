using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.OpenOrNot)]
    public readonly struct LeagueOpenOrNotRequest
    {
        internal LeagueOpenOrNotRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}