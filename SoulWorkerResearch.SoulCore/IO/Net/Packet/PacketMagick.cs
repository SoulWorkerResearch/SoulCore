using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.IO.Net.Packet;

[StructLayout(LayoutKind.Explicit)]
public readonly struct PacketMagick : IPacketMagick
{
    #region Contants

    public static PacketMagick Empty { get; } = new PacketMagick();

    #endregion Contants

    #region Properties

    public ushort Value => _value;

    #endregion Properties

    #region IPacketMagick

    byte IPacketMagick.Left => _left;
    byte IPacketMagick.Right => _right;

    #endregion IPacketMagick

    #region Constructors

    public PacketMagick(BinaryReader reader) => _value = reader.ReadUInt16();

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
