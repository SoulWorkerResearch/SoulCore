﻿using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record ServerGateBox : Entity
{
    /// <summary>
    ///
    /// </summary>
    public GateType Type { get; }

    /// <summary>
    ///
    /// </summary>
    public uint NextSector { get; }

    /// <summary>
    ///
    /// </summary>
    public uint Sector { get; }

    public ServerGateBox(XElement x) : base(x)
    {
        Type = x.GetEnum<GateType>("m_eType");
        NextSector = x.GetUInt32("m_iNextSectorID");
        Sector = x.GetUInt32("m_iSectorID");
    }
}
