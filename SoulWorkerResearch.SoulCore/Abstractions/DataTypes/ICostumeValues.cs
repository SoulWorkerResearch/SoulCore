namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface ICostumeValues
{
    IEnumerable<ICostumeValue> Shape { get; }
    IEnumerable<ICostumeValue> Look { get; }
}
