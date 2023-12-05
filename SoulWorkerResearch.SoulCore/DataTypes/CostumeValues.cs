namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct CostumeValues
{
    public IReadOnlyCollection<CostumeValue> Shape { get; init; } = Array.Empty<CostumeValue>();
    public IReadOnlyCollection<CostumeValue> Look { get; init; } = Array.Empty<CostumeValue>();

    internal CostumeValues(BinaryReader reader)
    {
        var items = Enumerable
            .Range(0, GameConfig.EquipableFashionStorageMaxCapacity)
            .Select(_ => (Battle: new CostumeValue(reader), View: new CostumeValue(reader)))
            .ToArray();

        Shape = items.Select(s => s.Battle).ToArray();
        Look = items.Select(s => s.View).ToArray();
    }
}
