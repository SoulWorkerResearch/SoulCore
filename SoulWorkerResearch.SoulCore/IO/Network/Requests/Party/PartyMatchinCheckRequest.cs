using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.MatchingCheck)]
    public readonly struct PartyMatchinCheckRequest
    {
        internal PartyMatchinCheckRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
