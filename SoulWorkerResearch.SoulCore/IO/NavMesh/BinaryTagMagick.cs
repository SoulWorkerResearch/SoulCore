using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.IO.NavMesh;

[StructLayout(LayoutKind.Explicit)]
public readonly struct BinaryTagMagick : IEquatable<BinaryTagMagick>
{
    #region Properties

    public uint First => _first;
    public uint Second => _second;

    #endregion Properties

    #region Overrides

    public override int GetHashCode() => _value.GetHashCode();

    public override bool Equals(object? obj) => obj is BinaryTagMagick && Equals(obj);

    #endregion Overrides

    #region IEquatable

    public bool Equals(BinaryTagMagick other) => other._value == _value;

    #endregion IEquatable

    #region Constructors

    public BinaryTagMagick(BinaryReader reader)
    {
        _value = reader.ReadUInt64();

        Debug.Assert(_first == 0xCAB00D1E);
        Debug.Assert(_second == 0xD011FACE);
    }

    public BinaryTagMagick()
    {
        _first = 0xCAB00D1E;
        _second = 0xD011FACE;
    }

    #endregion Constructors

    #region Private Fields

    [FieldOffset(0)]
    private readonly ulong _value = ulong.MinValue;

    [FieldOffset(0)]
    private readonly uint _first = uint.MinValue;

    [FieldOffset(4)]
    private readonly uint _second = uint.MinValue;

    #endregion Private Fields
}
