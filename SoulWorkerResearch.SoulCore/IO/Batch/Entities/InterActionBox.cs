using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record InterActionBox : BasicEntity
{
    public InterActionBox(XElement x) : base(x)
    {
        Interaction = x.GetUInt32("m_iInteractionID");
        ObjectKey = x.GetString("m_sObjectKey");
    }

    /// <summary>
    ///     Interactive table ID
    /// </summary>
    public uint Interaction { get; }

    /// <summary>
    ///     Interactive ObjectKey
    /// </summary>
    public string ObjectKey { get; }
}
