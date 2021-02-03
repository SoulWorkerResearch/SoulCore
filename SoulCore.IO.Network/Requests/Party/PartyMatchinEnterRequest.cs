using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.MatchingEnter)]
    public readonly struct PartyMatchinEnterRequest
    {
        internal PartyMatchinEnterRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}