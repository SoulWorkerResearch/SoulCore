using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Invite)]
    public readonly struct LeagueInviteRequest
    {
        internal LeagueInviteRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}