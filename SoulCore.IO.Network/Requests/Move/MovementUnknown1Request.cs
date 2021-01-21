using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct MovementUnknown1Request
    {
        public int Character { get; }
        public uint Unknown1 { get; }

        public MovementUnknown1Request(BinaryReader br) => (Character, Unknown1) = (br.ReadInt32(), br.ReadUInt32());
    }
}
