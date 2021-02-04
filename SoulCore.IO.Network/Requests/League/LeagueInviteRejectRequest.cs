using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.InviteReject)]
    public readonly struct LeagueInviteRejectRequest
    {
        internal LeagueInviteRejectRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}