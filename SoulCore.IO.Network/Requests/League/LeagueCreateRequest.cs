using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Create)]
    public readonly struct LeagueCreateRequest
    {
        internal LeagueCreateRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}