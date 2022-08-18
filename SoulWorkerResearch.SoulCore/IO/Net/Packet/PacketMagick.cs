using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.IO.Net.Packet;

[StructLayout(LayoutKind.Explicit)]
public struct PacketMagick
{
    #region Contants

    public static PacketMagick Empty { get; } = new PacketMagick();

    #endregion Contants

    #region Properties

    public byte Left => _left;
    public byte Right => _right;

    #endregion Properties

    #region Internal Properties

    internal ushort Value => _value;

    #endregion Internal Properties

    #region Constructors

    public PacketMagick(BinaryReader reader) => _value = reader.ReadUInt16();

    public PacketMagick(byte? left = null, byte? right = null)
    {
        _left = left ?? Config.PacketHeaderMagic0;
        _right = right ?? Config.PacketHeaderMagic1;
    }

    #endregion Constructors

    #region Private Properties

    [FieldOffset(0)]
    private readonly ushort _value;

    [FieldOffset(0)]
    private readonly byte _left = Config.PacketHeaderMagic0;

    [FieldOffset(1)]
    private readonly byte _right = Config.PacketHeaderMagic1;

    #endregion Private Properties
}
