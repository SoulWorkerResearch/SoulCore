using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct QuestAcceptRequest
    {
        public uint Id { get; }

        public QuestAcceptRequest(BinaryReader br) =>
            Id = br.ReadUInt32();
    }
}
