using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Delegate)]
    public readonly struct LeagueDelegateRequest
    {
        internal LeagueDelegateRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}