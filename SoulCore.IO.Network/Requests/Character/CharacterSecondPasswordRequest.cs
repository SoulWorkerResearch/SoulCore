using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.SecondPassword)]
    public readonly struct CharacterSecondPasswordRequest
    {
        internal CharacterSecondPasswordRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
