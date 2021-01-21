using System.IO;
using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct PostRecvListRequest
    {
        public uint Unknown1 { get; }

        public PostRecvListRequest(BinaryReader br) => Unknown1 = br.ReadUInt32();
    }
}
