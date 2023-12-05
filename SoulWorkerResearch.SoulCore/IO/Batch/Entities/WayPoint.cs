using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record WayPoint : BasicPoint
{
    public WayPoint(XElement x) : base(x)
    {
    }
}
