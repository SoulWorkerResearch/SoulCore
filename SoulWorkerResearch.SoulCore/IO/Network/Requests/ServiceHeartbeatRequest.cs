using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public sealed record ServiceHeartbeatRequest
    {
        public ulong Tick { get; }
        private ulong Unknown1 { get; }
        private uint Unknown2 { get; }

        public ServiceHeartbeatRequest(BinaryReader br) => (Tick, Unknown1, Unknown2) = (br.ReadUInt64(), br.ReadUInt64(), br.ReadUInt32());
    }
}
