using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record SectorStartBox : Entity
{
    /// <summary>
    ///
    /// </summary>
    public uint Sector { get; }

    public SectorStartBox(XElement x) : base(x) =>
        Sector = x.GetUInt32("m_nSectorID");
}
