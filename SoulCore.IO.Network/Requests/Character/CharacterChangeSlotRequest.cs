using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ChangeSlot)]
    public readonly struct CharacterChangeSlotRequest
    {
        internal CharacterChangeSlotRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
