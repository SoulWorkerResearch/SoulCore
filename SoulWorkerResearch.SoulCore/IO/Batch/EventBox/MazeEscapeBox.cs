using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record MazeEscapeBox : Entity
{
    /// <summary>
    /// Field ID
    /// </summary>
    public uint Field { get; }

    /// <summary>
    /// ID of Event Object.
    /// </summary>
    public uint EventObject { get; }

    public MazeEscapeBox(XElement x) : base(x)
    {
        Field = x.GetUInt32("m_iField");
        EventObject = x.GetUInt32("m_iEventObject");
    }
}
