using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes;

[StructLayout(LayoutKind.Explicit)]
public readonly struct MapValue : IMapValue
{
    public static MapValue Empty { get; } = new();

    [FieldOffset(0)]
    internal readonly ulong Value;

    [FieldOffset(3)]
    public readonly byte ChannelId;

    [FieldOffset(4)]
    public readonly ushort MapId;

    [FieldOffset(6)]
    public readonly ushort ServerId;

    #region IMapValue

    byte IMapValue.ChannelId => ChannelId;
    ushort IMapValue.MapId => MapId;
    ushort IMapValue.ServerId => ServerId;

    #endregion IMapValue

    internal MapValue(byte channelId, ushort mapId, ushort serverId)
    {
        Value = 0;
        ChannelId = channelId;
        MapId = mapId;
        ServerId = serverId;
    }

    internal MapValue(BinaryReader reader)
    {
        ChannelId = 0;
        MapId = 0;
        ServerId = 0;
        Value = reader.ReadUInt64();
    }
}
