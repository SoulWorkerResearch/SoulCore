using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record SectorStartBox : BasicEntity
{
    public SectorStartBox(XElement x) : base(x)
    {
        Sector = x.GetUInt32("m_nSectorID");
    }

    /// <summary>
    /// </summary>
    public uint Sector { get; }
}
