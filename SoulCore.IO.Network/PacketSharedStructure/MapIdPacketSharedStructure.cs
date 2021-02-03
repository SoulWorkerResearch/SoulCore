using System.IO;
using System.Runtime.InteropServices;

namespace SoulCore.IO.Network.Responses.Shared
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct MapIdPacketSharedStructure
    {
        [FieldOffset(0)]
        internal readonly ulong Seq;

        [FieldOffset(3)]
        public readonly byte ChannelId;

        [FieldOffset(4)]
        public readonly ushort MapId;

        [FieldOffset(6)]
        public readonly ushort ServerId;

        public MapIdPacketSharedStructure(byte channelId, ushort mapId, ushort serverId)
        {
            Seq = 0;
            ChannelId = channelId;
            MapId = mapId;
            ServerId = serverId;
        }

        public MapIdPacketSharedStructure(BinaryReader br)
        {
            ChannelId = 0;
            MapId = 0;
            ServerId = 0;
            Seq = br.ReadUInt64();
        }

        public static MapIdPacketSharedStructure Empty { get; } = new();
    }
}