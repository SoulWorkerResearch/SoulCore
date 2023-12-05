using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes.Entities;

[StructLayout(LayoutKind.Explicit)]
public readonly struct HairEntity(BinaryReader reader)
{
    [field: FieldOffset(0)]
    public readonly ushort Style { get; init; }

    [field: FieldOffset(2)]
    public readonly ushort Color { get; init; }

    [field: FieldOffset(0)]
    internal readonly uint Value { get; } = reader.ReadUInt32();
}
