using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct PostRecvListRequest
    {
        public uint Unknown1 { get; }

        public PostRecvListRequest(BinaryReader br) => Unknown1 = br.ReadUInt32();
    }
}
