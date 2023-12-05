using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes.Entities;

[StructLayout(LayoutKind.Explicit, Size = sizeof(long))]
public readonly struct CardInfoEntity(BinaryReader reader)
{
    [field: FieldOffset(0)]
    public readonly ushort Primary { get; init; }

    [field: FieldOffset(2)]
    public readonly ushort Secondary { get; init; }

    [field: FieldOffset(0)]
    internal readonly uint Value { get; } = reader.ReadUInt32();
}
