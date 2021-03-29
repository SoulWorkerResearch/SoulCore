using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct QuestAcceptRequest
    {
        public uint Id { get; }

        public QuestAcceptRequest(BinaryReader br) =>
            Id = br.ReadUInt32();
    }
}
