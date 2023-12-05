using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record CommonPositionBox : BasicEntity
{
    public CommonPositionBox(XElement x) : base(x)
    {
        EntityType = x.GetEnum<EntityType>("m_eEntityType");
        Entity = x.GetUInt32("m_iEntityID");
        Group = x.GetUInt32("m_iGroup");
    }

    /// <summary>
    /// </summary>
    public EntityType EntityType { get; }

    /// <summary>
    /// </summary>
    public uint Entity { get; }

    /// <summary>
    /// </summary>
    public uint Group { get; }
}
