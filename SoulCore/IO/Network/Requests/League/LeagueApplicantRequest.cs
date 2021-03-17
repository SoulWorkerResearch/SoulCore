using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Applicant)]
    public readonly struct LeagueApplicantRequest
    {
        internal LeagueApplicantRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}