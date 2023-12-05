using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record MazeEscapeBox : BasicEntity
{
    public MazeEscapeBox(XElement x) : base(x)
    {
        Field = x.GetUInt32("m_iField");
        EventObject = x.GetUInt32("m_iEventObject");
    }

    /// <summary>
    ///     Field ID
    /// </summary>
    public uint Field { get; }

    /// <summary>
    ///     ID of Event Object.
    /// </summary>
    public uint EventObject { get; }
}
