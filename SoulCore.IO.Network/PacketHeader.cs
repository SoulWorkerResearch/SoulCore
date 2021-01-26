using System.IO;

namespace SoulCore.IO.Network
{
    public readonly struct PacketHeader
    {
        public byte Magic0 { get; }
        public byte Magic1 { get; }
        public ushort Size { get; }
        public byte usTos { get; }

        public PacketHeader(BinaryReader br)
        {
            Magic0 = br.ReadByte();
            Magic1 = br.ReadByte();
            Size = br.ReadUInt16();
            usTos = br.ReadByte();
        }
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8