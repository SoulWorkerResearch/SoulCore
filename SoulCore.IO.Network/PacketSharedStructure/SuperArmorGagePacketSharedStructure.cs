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
}