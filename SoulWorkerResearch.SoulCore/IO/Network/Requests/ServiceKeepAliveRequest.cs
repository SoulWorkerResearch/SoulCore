using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.Extensions;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct ServiceKeepAliveRequest
    {
        public uint Seed { get; }
        public uint Unknown1 { get; }
        public uint Unknown2 { get; }
        public uint Unknown3 { get; }
        public ulong TickCount { get; }
        public string Hash { get; }

        public ServiceKeepAliveRequest(BinaryReader br)
        {
            Seed = br.ReadUInt32();
            Unknown1 = br.ReadUInt32();
            Unknown2 = br.ReadUInt32();
            Unknown3 = br.ReadUInt32();
            TickCount = br.ReadUInt64();
            Hash = br.ReadByteLengthUtf8String();
        }
    }
}
