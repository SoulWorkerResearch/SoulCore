using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.ApplicantAccept)]
    public readonly struct LeagueApplicantAcceptRequest
    {
        internal LeagueApplicantAcceptRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}