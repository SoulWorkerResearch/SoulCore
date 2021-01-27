using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.RepresentativeCheck)]
    public readonly struct CharacterRepresentativeCheckRequest
    {
        internal CharacterRepresentativeCheckRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
