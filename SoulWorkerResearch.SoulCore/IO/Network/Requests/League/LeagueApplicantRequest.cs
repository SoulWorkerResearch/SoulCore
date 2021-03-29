using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.League
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
