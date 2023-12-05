namespace SoulWorkerResearch.SoulCore.IO.Net.DataTypes;

public readonly struct TickcountValue(BinaryReader reader)
{
    public uint Ticknum { get; } = reader.ReadUInt32();
    public ulong Tickcount { get; } = reader.ReadUInt64();
}
