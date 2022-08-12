using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct AppearanceValue : IAppearanceValue
{
    public static AppearanceValue Empty { get; } = new();

    public ushort Face { get; init; }
    public AppearanceEntryValue Shape { get; init; }
    public AppearanceEntryValue Look { get; init; }

    #region IAppearanceValue

    IAppearanceEntryValue IAppearanceValue.Shape => Shape;
    IAppearanceEntryValue IAppearanceValue.Look => Look;

    #endregion IAppearanceValue

    internal AppearanceValue(BinaryReader reader)
    {
        Face = reader.ReadUInt16();
        Shape = new(reader);
        Look = new(reader);
    }
}
