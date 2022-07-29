﻿using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record CheckMonsterSpawnBox : Entity
{
    /// <summary>
    /// CheckType
    /// </summary>
    public MonsterType Type { get; }

    /// <summary>
    /// LoopCount
    /// </summary>
    public uint LoopCount { get; }

    /// <summary>
    /// Target ID to work with this box to collide (as CheckType and find the target in combination)
    /// </summary>
    public uint Entity { get; }

    /// <summary>
    ///
    /// </summary>
    public IReadOnlyList<uint> CheckBoxes { get; }

    public CheckMonsterSpawnBox(XElement x) : base(x)
    {
        Type = x.GetEnum<MonsterType>("m_eType");
        LoopCount = x.GetUInt32("m_iLoopCount");
        Entity = x.GetUInt32("m_iEntityID");
        CheckBoxes = Enumerable.Range(0, 10).Select(id => x.GetUInt32($"m_iCheckBox_{id}")).ToArray();
    }
}