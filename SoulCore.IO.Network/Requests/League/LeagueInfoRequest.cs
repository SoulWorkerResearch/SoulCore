using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Info)]
    public readonly struct LeagueInfoRequest
    {
        internal LeagueInfoRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}