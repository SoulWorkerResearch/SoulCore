using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.IO.NavMesh;

[StructLayout(LayoutKind.Explicit)]
public readonly struct BinaryTagMagic(BinaryReader reader) : IEquatable<BinaryTagMagic>
{
    #region Properties

    [field: FieldOffset(0)]
    public uint First { get; } = 0xCAB00D1E;

    [field: FieldOffset(4)]
    public uint Second { get; } = 0xD011FACE;

    public bool IsValid => First == 0xCAB00D1E && Second == 0xD011FACE;

    #endregion Properties

    #region Overrides

    public override int GetHashCode() => _value.GetHashCode();

    public override bool Equals(object? obj) => obj is BinaryTagMagic && Equals(obj);

    public static bool operator ==(BinaryTagMagic left, BinaryTagMagic right) => left.Equals(right);

    public static bool operator !=(BinaryTagMagic left, BinaryTagMagic right) => !(left == right);

    #endregion Overrides

    #region IEquatable

    public bool Equals(BinaryTagMagic other) => other._value == _value;

    #endregion IEquatable

    #region Private Fields

    [FieldOffset(0)] 
    private readonly ulong _value = reader.ReadUInt64();

    #endregion Private Fields
}
