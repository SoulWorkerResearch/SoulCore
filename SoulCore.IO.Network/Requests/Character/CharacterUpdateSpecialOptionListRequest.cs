using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.UpdateSpecialOptionList)]
    public readonly struct CharacterUpdateSpecialOptionListRequest
    {
        public readonly int Character;

        internal CharacterUpdateSpecialOptionListRequest(BinaryReader br)
        {
            Character = br.ReadInt32();
        }
    }
}
