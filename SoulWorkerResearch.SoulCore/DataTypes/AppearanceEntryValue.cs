using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct AppearanceEntryValue : IAppearanceEntryValue
{
    public HairValue Hair { get; init; }
    public ushort EyeColor { get; init; }
    public ushort SkinColor { get; init; }

    internal AppearanceEntryValue(BinaryReader reader)
    {
        Hair = new(reader);
        EyeColor = reader.ReadUInt16();
        SkinColor = reader.ReadUInt16();
    }
}
