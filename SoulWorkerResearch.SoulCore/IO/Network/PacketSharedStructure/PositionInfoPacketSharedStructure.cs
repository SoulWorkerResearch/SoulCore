using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Responses.Shared;
using System.IO;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Network.PacketSharedStructure
{
    public readonly struct PositionInfoPacketSharedStructure
    {
        internal static readonly PositionInfoPacketSharedStructure Empty = new();

        public ushort LocationId { get; init; }
        public MapIdPacketSharedStructure MapId { get; init; }
        public Vector3 Position { get; init; }
        public float Rotation { get; init; }

        internal PositionInfoPacketSharedStructure(BinaryReader br)
        {
            LocationId = br.ReadUInt16();
            MapId = new(br);
            Position = br.ReadVector3();
            Rotation = br.ReadSingle();
        }
    };
}
