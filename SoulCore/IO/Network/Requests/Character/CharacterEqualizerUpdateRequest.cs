using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.EqualizerUpdate)]
    public readonly struct CharacterEqualizerUpdateRequest
    {
        internal CharacterEqualizerUpdateRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
