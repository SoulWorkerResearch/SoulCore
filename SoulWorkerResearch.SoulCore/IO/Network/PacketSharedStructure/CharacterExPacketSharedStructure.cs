using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.PacketSharedStructure
{
    public readonly struct CharacterExPacketSharedStructure
    {
        public CharacterPacketSharedStructure Character { get; init; }
        public PositionInfoPacketSharedStructure Position { get; init; }
        public SuperArmorGagePacketSharedStructure SuperArmorGage { get; init; }

        internal CharacterExPacketSharedStructure(BinaryReader br)
        {
            Character = new(br);
            Position = new(br);
            SuperArmorGage = new(br);
        }
    }
}
