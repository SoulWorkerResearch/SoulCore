using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
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