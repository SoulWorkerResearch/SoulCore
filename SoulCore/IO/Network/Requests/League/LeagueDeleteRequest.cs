using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Delete)]
    public readonly struct LeagueDeleteRequest
    {
        internal LeagueDeleteRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}