using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    public enum UsTos
    {
        _1 = 1,
        _2 = 2,
    }

    public readonly struct PacketHeader
    {
        public readonly byte Magic0;
        public readonly byte Magic1;
        public readonly ushort BodySize;
        public readonly UsTos UsTos;

        public PacketHeader(BinaryReader br)
        {
            Magic0 = br.ReadByte();
            Magic1 = br.ReadByte();
            BodySize = br.ReadUInt16();
            UsTos = (UsTos)br.ReadByte();
        }
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8
