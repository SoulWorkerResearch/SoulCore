using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes.Entities;

[StructLayout(LayoutKind.Explicit)]
public readonly struct StatEntity(BinaryReader reader)
{
    [field: FieldOffset(0)]
    public readonly uint Current { get; }

    [field: FieldOffset(4)]
    public readonly uint Max { get; }

    [field: FieldOffset(0)]
    internal readonly ulong Value { get; init; } = reader.ReadUInt64();
}
