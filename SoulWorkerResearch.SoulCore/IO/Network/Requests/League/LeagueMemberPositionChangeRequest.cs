using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.MemberPositionChange)]
    public readonly struct LeagueMemberPositionChangeRequest
    {
        internal LeagueMemberPositionChangeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
