using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.InventoryInfo)]
    public readonly struct LeagueInventoryInfoRequest
    {
        internal LeagueInventoryInfoRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}