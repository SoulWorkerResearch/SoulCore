using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.Cancel)]
    public readonly struct PartyCancelRequest
    {
        internal PartyCancelRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
