using SoulWorkerResearch.SoulCore.DataTypes;

namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface IAppearanceEntryValue
{
    ushort EyeColor { get; }
    HairValue Hair { get; }
    ushort SkinColor { get; }
}
