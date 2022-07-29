namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface IAppearanceValue
{
    ushort Face { get; }
    IHairValue Hair { get; }
    ushort EyeColor { get; }
    ushort SkinColor { get; }
    IHairValue EquippedHair { get; }
    ushort EquippedEyeColor { get; }
    ushort EquippedSkinColor { get; }
}
