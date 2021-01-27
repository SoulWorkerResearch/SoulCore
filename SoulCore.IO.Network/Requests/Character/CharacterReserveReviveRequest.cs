using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ReserveRevive)]
    public readonly struct CharacterReserveReviveRequest
    {
        internal CharacterReserveReviveRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
