using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.PositionNameChange)]
    public readonly struct LeaguePositionNameChangeRequest
    {
        internal LeaguePositionNameChangeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}