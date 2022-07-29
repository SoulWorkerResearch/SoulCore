namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface IStatValues
{
    /// <summary>
    /// Health
    /// </summary>
    IStatValue Hp { get; }

    /// <summary>
    /// SoulGain (Mana)
    /// </summary>
    IStatValue Sg { get; }

    /// <summary>
    /// SoulVapor (Ultimate)
    /// </summary>
    IStatValue Sv { get; }

    /// <summary>
    /// Stamina
    /// </summary>
    IStatValue St { get; }

    /// <summary>
    /// Watafak?
    /// </summary>
    IStatValue Fd { get; }

    /// <summary>
    /// AttackSpeed
    /// </summary>
    float As { get; }

    /// <summary>
    /// MoveSpeed
    /// </summary>
    float Ms { get; }

}
