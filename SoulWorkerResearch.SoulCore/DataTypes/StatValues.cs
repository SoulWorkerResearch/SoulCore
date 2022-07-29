using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct StatValues : IStatValues
{
    public static StatValues Empty { get; } = new();

    /// <summary>
    /// Health Point
    /// </summary>
    public StatValue Hp { get; init; }

    /// <summary>
    /// Soul Gain
    /// </summary>
    public StatValue Sg { get; init; }

    /// <summary>
    /// Soul Vapor
    /// </summary>
    public StatValue Sv { get; init; }

    /// <summary>
    /// Stamina
    /// </summary>
    public StatValue St { get; init; }

    /// <summary>
    /// IDK
    /// </summary>
    public StatValue Fd { get; init; }

    public float As { get; init; }
    public float Ms { get; init; }

    #region IStatValues

    IStatValue IStatValues.Hp => Hp;
    IStatValue IStatValues.Sg => Sg;
    IStatValue IStatValues.Sv => Sv;
    IStatValue IStatValues.St => St;
    IStatValue IStatValues.Fd => Fd;

    #endregion IStatValues

    internal StatValues(BinaryReader reader)
    {
        Hp = new(reader);
        Sg = new(reader);
        Sv = new(reader);
        St = new(reader);
        Fd = new(reader);
        As = reader.ReadSingle();
        Ms = reader.ReadSingle();
    }
}
