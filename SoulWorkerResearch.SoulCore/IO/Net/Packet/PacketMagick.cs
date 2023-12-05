using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.IO.Net.Packet;

[StructLayout(LayoutKind.Explicit)]
public readonly struct PacketMagick
{
    #region Contants

    public static PacketMagick Empty => new();

    #endregion Contants

    #region Properties
    
    public bool IsValid => Value == GameConfig.PacketHeaderMagic;

    [field: FieldOffset(0)]
    public byte Left { get; }

    [field: FieldOffset(1)] 
    public byte Right { get; }

    #endregion Properties

    #region Internal Properties

    [field: FieldOffset(0)]
    internal ushort Value { get; } = GameConfig.PacketHeaderMagic;

    #endregion Internal Properties

    #region Constructors

    public PacketMagick(BinaryReader reader) => Value = reader.ReadUInt16();

    public PacketMagick(byte? left = null, byte? right = null)
    {
        Left = left ?? GameConfig.PacketHeaderMagic0;
        Right = right ?? GameConfig.PacketHeaderMagic1;
    }

    #endregion Constructors
}
