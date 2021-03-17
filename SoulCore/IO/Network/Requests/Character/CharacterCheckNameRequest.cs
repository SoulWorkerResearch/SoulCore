using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.CheckName)]
    public readonly struct CharacterCheckNameRequest
    {
        internal CharacterCheckNameRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
