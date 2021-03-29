using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct QuestEpisodeCompleteRequest
    {
        public uint QuestId { get; }
        public uint Episode { get; }

        public QuestEpisodeCompleteRequest(BinaryReader br) => (QuestId, Episode) = (br.ReadUInt32(), br.ReadUInt32());
    }
}
