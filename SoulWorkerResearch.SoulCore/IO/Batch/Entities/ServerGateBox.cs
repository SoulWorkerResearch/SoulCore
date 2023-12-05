using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record ServerGateBox : BasicEntity
{
    public ServerGateBox(XElement x) : base(x)
    {
        Type = x.GetEnum<GateType>("m_eType");
        NextSector = x.GetUInt32("m_iNextSectorID");
        Sector = x.GetUInt32("m_iSectorID");
    }

    /// <summary>
    /// </summary>
    public GateType Type { get; }

    /// <summary>
    /// </summary>
    public uint NextSector { get; }

    /// <summary>
    /// </summary>
    public uint Sector { get; }
}
