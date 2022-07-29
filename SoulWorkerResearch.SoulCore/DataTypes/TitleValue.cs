using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes;

[StructLayout(LayoutKind.Explicit)]
public readonly struct TitleValue : ITitleValue
{
    public static TitleValue Empty { get; } = new();

    [FieldOffset(0)]
    internal readonly ulong Value;

    [FieldOffset(0)]
    public readonly uint Prefix;

    [FieldOffset(4)]
    public readonly uint Suffix;

    #region ITitleValue

    uint ITitleValue.Prefix => Prefix;
    uint ITitleValue.Suffix => Suffix;

    #endregion ITitleValue

    internal TitleValue(BinaryReader reader)
    {
        Prefix = 0;
        Suffix = 0;
        Value = reader.ReadUInt64();
    }
}
