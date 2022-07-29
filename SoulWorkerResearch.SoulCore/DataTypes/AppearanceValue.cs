using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct AppearanceValue : IAppearanceValue
{
    public static AppearanceValue Empty { get; } = new();

    public ushort Face { get; init; }
    public HairValue Hair { get; init; }
    public ushort EyeColor { get; init; }
    public ushort SkinColor { get; init; }
    public HairValue EquippedHair { get; init; }
    public ushort EquippedEyeColor { get; init; }
    public ushort EquippedSkinColor { get; init; }

    #region IAppearanceValue

    IHairValue IAppearanceValue.Hair => Hair;
    IHairValue IAppearanceValue.EquippedHair => EquippedHair;

    #endregion IAppearanceValue

    internal AppearanceValue(BinaryReader reader)
    {
        Face = reader.ReadUInt16();
        Hair = new(reader);
        EyeColor = reader.ReadUInt16();
        SkinColor = reader.ReadUInt16();
        EquippedHair = new(reader);
        EquippedEyeColor = reader.ReadUInt16();
        EquippedSkinColor = reader.ReadUInt16();
    }
}
