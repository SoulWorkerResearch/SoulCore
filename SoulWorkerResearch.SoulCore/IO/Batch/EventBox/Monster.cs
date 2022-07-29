using SoulWorkerResearch.SoulCore.IO.Batch.Types;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record Monster
{
    /// <summary>
    /// Monster ID
    /// </summary>
    public uint Id { get; }

    /// <summary>
    /// Monster Spawn Type
    /// </summary>
    public MonsterSpawnType Type { get; }

    /// <summary>
    /// Monster Chance(0~10000)
    ///
    /// M11_BREAKOUT_EP_03.vbatch
    /// M07_CONCRETEJUNGLE_EP_04.vbatch
    /// <m_iChance4 type="0" value="100000" />
    /// </summary>
    public uint Chance { get; }

    public Monster(uint id, MonsterSpawnType type, uint chance) =>
        (Id, Type, Chance) = (id, type, chance);
}
