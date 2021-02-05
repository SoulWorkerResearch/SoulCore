using SoulCore.Extensions;
using SoulCore.IO.Network.Responses.Shared;
using System.IO;
using System.Numerics;

namespace SoulCore.IO.Network.PacketSharedStructure
{
    public readonly struct PositionInfoPacketSharedStructure
    {
        public ushort WorldId { get; init; }
        public MapIdPacketSharedStructure MapId { get; init; }
        public Vector3 Position { get; init; }
        public float Rotation { get; init; }

        internal PositionInfoPacketSharedStructure(BinaryReader br)
        {
            WorldId = br.ReadUInt16();
            MapId = new(br);
            Position = br.ReadVector3();
            Rotation = br.ReadSingle();
        }
    };
}