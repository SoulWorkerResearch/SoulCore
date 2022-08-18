using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes;

[StructLayout(LayoutKind.Explicit)]
public readonly struct SteamId
{
    #region Properties

    public ulong Id64 => _64;
    public uint Id32 => _32;

    #endregion Properties

    #region Operators

    public static implicit operator ulong(SteamId value) => value._64;
    public static implicit operator uint(SteamId value) => value._32;

    #endregion Operators

    #region Constructors

    public SteamId(BinaryReader reader) => _value = reader.ReadUInt64();

    #endregion Constructors

    #region Private Fields

    [FieldOffset(0)]
    private readonly ulong _value = 0;

    [FieldOffset(0)]
    private readonly ulong _64 = 0;

    [FieldOffset(0)]
    private readonly uint _32 = 0;

    #endregion Private Fields
}
