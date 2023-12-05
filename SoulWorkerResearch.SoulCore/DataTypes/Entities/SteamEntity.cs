using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes.Entities;

[StructLayout(LayoutKind.Explicit, Size = sizeof(long))]
public readonly struct SteamEntity(BinaryReader reader)
{
    [field: FieldOffset(0)]
    public ulong Id64 { get; }

    [field: FieldOffset(0)]
    public uint Id32 { get; }

    [FieldOffset(0)]
    internal readonly ulong Value = reader.ReadUInt64();

    public static implicit operator ulong(SteamEntity value) => value.Id64;

    public static implicit operator uint(SteamEntity value) => value.Id32;
}
