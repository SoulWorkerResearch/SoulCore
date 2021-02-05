using System.IO;

namespace SoulCore.IO.Network.PacketSharedStructure
{
    public readonly struct SuperArmorGagePacketSharedStructure
    {
        public float Current { get; init; }
        public float Max { get; init; }

        internal SuperArmorGagePacketSharedStructure(BinaryReader br)
        {
            Current = br.ReadSingle();
            Max = br.ReadSingle();
        }
    }

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