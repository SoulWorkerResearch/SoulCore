using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ChangeMotion)]
    public readonly struct CharacterChangeMotionRequest
    {
        internal CharacterChangeMotionRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}

