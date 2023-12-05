using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public abstract record BasicPoint : BasicEntity
{
    protected BasicPoint(XElement x) : base(x)
    {
        Type = x.GetEnum<PointType>("m_eType");
        BattleType = x.GetEnum<BattleType>("m_eBattleType");
        BeforePoint = x.GetUInt32("m_iBeforePoint");
        NextPoints = Enumerable.Range(1, 4).Select(id => x.GetUInt32($"m_iNextPoint{(id > 1 ? id : "")}")).ToArray();
        IdleAction = x.GetString("m_szIdleAction");
        IdleActionRatio = x.GetUInt32("m_uiIdleActionRatio");
        DelayTime = x.GetUInt32("m_uiDelayTime");
        RepeatCount = x.GetByte("m_RepeatCount");
    }

    /// <summary>
    /// </summary>
    public PointType Type { get; }

    /// <summary>
    /// </summary>
    public BattleType BattleType { get; }

    /// <summary>
    /// </summary>
    public uint BeforePoint { get; }

    /// <summary>
    /// </summary>
    public IReadOnlyList<uint> NextPoints { get; }

    /// <summary>
    /// </summary>
    public string IdleAction { get; }

    /// <summary>
    /// </summary>
    public uint IdleActionRatio { get; }

    /// <summary>
    /// </summary>
    public uint DelayTime { get; }

    /// <summary>
    /// </summary>
    public byte RepeatCount { get; }
}
