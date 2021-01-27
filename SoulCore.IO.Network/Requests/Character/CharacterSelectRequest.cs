using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.Select)]
    public readonly struct CharacterSelectRequest
    {
        internal CharacterSelectRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
