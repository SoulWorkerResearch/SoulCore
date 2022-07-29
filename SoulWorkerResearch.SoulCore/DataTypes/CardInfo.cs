using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes;

[StructLayout(LayoutKind.Explicit)]
public readonly struct CardInfo : ICardInfo
{
    #region Properties

    public static CardInfo Empty { get; } = new();

    #endregion Properties

    #region Fields

    [FieldOffset(0)]
    public readonly ushort Design;

    [FieldOffset(2)]
    public readonly ushort BackDesign;

    #endregion Fields

    #region ICardInfo

    ushort ICardInfo.Design => Design;
    ushort ICardInfo.BackDesign => BackDesign;

    #endregion ICardInfo

    #region Internal Fields

    [FieldOffset(0)]
    internal readonly uint Value;

    #endregion Internal Fields

    #region Internal Constructors

    internal CardInfo(BinaryReader reader)
    {
        Design = 0;
        BackDesign = 0;
        Value = reader.ReadUInt32();
    }

    #endregion Internal Constructors
}
