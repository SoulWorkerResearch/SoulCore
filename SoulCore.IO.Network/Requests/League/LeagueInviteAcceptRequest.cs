using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.InviteAccept)]
    public readonly struct LeagueInviteAcceptRequest
    {
        internal LeagueInviteAcceptRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}