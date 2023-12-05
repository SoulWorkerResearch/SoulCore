using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes.Entities;

[StructLayout(LayoutKind.Explicit, Size = sizeof(ulong))]
public readonly struct TitleEntity(BinaryReader reader)
{
    [field: FieldOffset(0)]
    public readonly uint Prefix { get; init; }

    [field: FieldOffset(4)]
    public readonly uint Suffix { get; init; }

    [field: FieldOffset(0)]
    internal readonly ulong Value { get; } = reader.ReadUInt64();
}
