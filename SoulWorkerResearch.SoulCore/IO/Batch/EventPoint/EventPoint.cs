using System.Xml.Linq;
using System.Xml.XPath;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventPoint;

public sealed record EventPoint
{
    public IReadOnlyList<WayPoint> WayPoints { get; }
    public IReadOnlyList<EscortPoint> EscortPoints { get; }

    public EventPoint(XElement x)
    {
        WayPoints = x.XPathSelectElements("VWayPoint").Select(v => new WayPoint(v)).ToArray();
        EscortPoints = x.XPathSelectElements("VEscortPoint").Select(v => new EscortPoint(v)).ToArray();
    }
}
