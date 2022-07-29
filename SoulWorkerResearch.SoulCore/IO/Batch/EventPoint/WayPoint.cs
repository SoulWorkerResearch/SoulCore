using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventPoint;

public sealed record WayPoint : Point
{
    public WayPoint(XElement x) : base(x)
    {
    }
}
