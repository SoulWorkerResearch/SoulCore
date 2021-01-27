using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.RepresentativeChange)]
    public readonly struct CharacterRepresentativeChangeRequest
    {
        internal CharacterRepresentativeChangeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
