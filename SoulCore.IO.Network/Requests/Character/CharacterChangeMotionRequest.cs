using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ChangeMotionReq)]
    public readonly struct CharacterChangeMotionRequest
    {
        public readonly int Character;
        public readonly short SubMotion;

        internal CharacterChangeMotionRequest(BinaryReader br)
        {
            Character = br.ReadInt32();
            SubMotion = br.ReadInt16();
        }
    }
}

