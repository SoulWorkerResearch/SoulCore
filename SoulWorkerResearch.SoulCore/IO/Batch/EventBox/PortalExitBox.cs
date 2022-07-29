using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record PortalExitBox : Entity
{
    /// <summary>
    /// PortalBox ID of connected
    /// </summary>
    public uint ParentPortal { get; }

    public PortalExitBox(XElement x) : base(x) =>
        ParentPortal = x.GetUInt32("m_iParentPortalBoxID");
}
