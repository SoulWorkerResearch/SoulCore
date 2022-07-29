using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes;

[StructLayout(LayoutKind.Explicit)]
public readonly struct StatValue : IStatValue
{
    public static StatValue Empty { get; } = new();

    [FieldOffset(0)]
    internal readonly ulong Value;

    [FieldOffset(0)]
    public readonly uint Current;

    [FieldOffset(4)]
    public readonly uint Max;

    #region IStatValue

    uint IStatValue.Current => Current;
    uint IStatValue.Max => Max;

    #endregion IStatValue

    internal StatValue(BinaryReader reader)
    {
        Current = 0;
        Max = 0;
        Value = reader.ReadUInt64();
    }
}
