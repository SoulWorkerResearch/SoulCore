namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface IBuffValue
{
    int Id { get; }
    float Time { get; }
    byte Count { get; }
    uint OwnerId { get; }
    byte Show { get; }
}
