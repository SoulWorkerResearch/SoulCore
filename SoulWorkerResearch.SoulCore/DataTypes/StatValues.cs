using SoulWorkerResearch.SoulCore.DataTypes.Entities;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct StatValues
{
    public StatEntity Health { get; init; }
    public StatEntity SoulGain { get; init; }
    public StatEntity SoulVapor { get; init; }
    public StatEntity Stamina { get; init; }

    /// <summary>
    ///     IDK
    /// </summary>
    public StatEntity Fd { get; init; }

    public float AttackSpeed { get; init; }
    public float MoveSpeed { get; init; }

    internal StatValues(BinaryReader reader)
    {
        Health = new StatEntity(reader);
        SoulGain = new StatEntity(reader);
        SoulVapor = new StatEntity(reader);
        Stamina = new StatEntity(reader);
        Fd = new StatEntity(reader);
        AttackSpeed = reader.ReadSingle();
        MoveSpeed = reader.ReadSingle();
    }
}
