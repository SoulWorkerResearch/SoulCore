using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record PortalExitBox : BasicEntity
{
    public PortalExitBox(XElement x) : base(x)
    {
        ParentPortal = x.GetUInt32("m_iParentPortalBoxID");
    }

    /// <summary>
    ///     PortalBox ID of connected
    /// </summary>
    public uint ParentPortal { get; }
}
