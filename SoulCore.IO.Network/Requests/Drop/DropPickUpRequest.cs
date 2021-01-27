using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Drop
{
    [Request(CategoryCommand.Drop, DropCommand.PickUp)]
    public readonly struct DropPickUpRequest
    {
        internal DropPickUpRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}