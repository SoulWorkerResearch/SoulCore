using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.ApplicantReject)]
    public readonly struct LeagueApplicantRejectRequest
    {
        internal LeagueApplicantRejectRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}