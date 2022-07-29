using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record CommonPositionBox : Entity
{
    /// <summary>
    ///
    /// </summary>
    public EntityType EntityType { get; }

    /// <summary>
    ///
    /// </summary>
    public uint Entity { get; }

    /// <summary>
    ///
    /// </summary>
    public uint Group { get; }

    public CommonPositionBox(XElement x) : base(x)
    {
        EntityType = x.GetEnum<EntityType>("m_eEntityType");
        Entity = x.GetUInt32("m_iEntityID");
        Group = x.GetUInt32("m_iGroup");
    }
}
