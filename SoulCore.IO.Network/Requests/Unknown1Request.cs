using System.IO;
using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct Unknown1Request
    {
        public byte Unknown1 { get; }

        public Unknown1Request(BinaryReader br) =>
            Unknown1 = br.ReadByte();
    }
}
