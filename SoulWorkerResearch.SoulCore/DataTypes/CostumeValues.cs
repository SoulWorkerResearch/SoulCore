using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct CostumeValues : ICostumeValues
{
    public static CostumeValues Empty { get; } = new();

    public IReadOnlyList<CostumeValue> Shape { get; init; } = Array.Empty<CostumeValue>();
    public IReadOnlyList<CostumeValue> Look { get; init; } = Array.Empty<CostumeValue>();

    #region ICostumeValues

    IEnumerable<ICostumeValue> ICostumeValues.Shape => Shape.Cast<ICostumeValue>();
    IEnumerable<ICostumeValue> ICostumeValues.Look => Look.Cast<ICostumeValue>();

    #endregion ICostumeValues

    internal CostumeValues(BinaryReader reader)
    {
        var items = Enumerable
            .Range(0, Config.EquipableFashionStorageMaxCapacity)
            .Select(_ => (Battle: new CostumeValue(reader), View: new CostumeValue(reader)))
            .ToArray();

        Shape = items.Select(s => s.Battle).ToArray();
        Look = items.Select(s => s.View).ToArray();
    }
}
