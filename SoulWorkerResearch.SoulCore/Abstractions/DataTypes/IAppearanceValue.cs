namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface IAppearanceValue
{
    ushort Face { get; }
    IAppearanceEntryValue Shape { get; }
    IAppearanceEntryValue Look { get; }
}
