using System.IO;

namespace SoulCore.IO.Network
{
    public readonly struct PacketHeader
    {
        public readonly byte Magic0;
        public readonly byte Magic1;
        public readonly ushort Size;
        public readonly byte UsTos;

        public PacketHeader(BinaryReader br)
        {
            Magic0 = br.ReadByte();
            Magic1 = br.ReadByte();
            Size = br.ReadUInt16();
            UsTos = br.ReadByte();
        }
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8