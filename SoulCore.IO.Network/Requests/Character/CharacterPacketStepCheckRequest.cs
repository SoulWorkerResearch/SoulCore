using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.PacketStepCheck)]
    public readonly struct CharacterPacketStepCheckRequest
    {
        public readonly int CharacterId;

        internal CharacterPacketStepCheckRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
        }
    }
}
