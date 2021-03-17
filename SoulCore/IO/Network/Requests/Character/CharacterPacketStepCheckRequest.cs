using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.PacketStepCheck)]
    public readonly struct CharacterPacketStepCheckRequest
    {
        public readonly int CharacterId;

        internal CharacterPacketStepCheckRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}