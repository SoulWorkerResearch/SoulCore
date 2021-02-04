using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Board)]
    public readonly struct LeagueBoardRequest
    {
        internal LeagueBoardRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}