using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record InterActionBox : Entity
{
    /// <summary>
    /// Interactive table ID
    /// </summary>
    public uint Interaction { get; }

    /// <summary>
    /// Interactive ObjectKey
    /// </summary>
    public string ObjectKey { get; }

    public InterActionBox(XElement x) : base(x)
    {
        Interaction = x.GetUInt32("m_iInteractionID");
        ObjectKey = x.GetString("m_sObjectKey");
    }
}
