using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.PacketStepCheck)]
    public readonly struct CharacterPacketStepCheckRequest
    {
        public readonly int CharacterId;

        internal CharacterPacketStepCheckRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
