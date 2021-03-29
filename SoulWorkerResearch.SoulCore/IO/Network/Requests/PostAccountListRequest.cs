using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct PostAccountListRequest
    {
        public uint Unknown1 { get; }

        public PostAccountListRequest(BinaryReader br) => Unknown1 = br.ReadUInt32();
    }
}
