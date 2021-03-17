using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
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