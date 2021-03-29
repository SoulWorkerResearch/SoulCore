using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.League
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
