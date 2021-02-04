using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.CardChange)]
    public readonly struct LeagueCardChangeRequest
    {
        internal LeagueCardChangeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}