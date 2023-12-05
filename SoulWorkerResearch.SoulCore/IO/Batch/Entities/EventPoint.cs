using System.Xml.Linq;
using System.Xml.XPath;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record EventPoint
{
    public EventPoint(XElement x)
    {
        WayPoints = x.XPathSelectElements("VWayPoint").Select(v => new WayPoint(v)).ToArray();
        EscortPoints = x.XPathSelectElements("VEscortPoint").Select(v => new EscortPoint(v)).ToArray();
    }

    public IReadOnlyList<WayPoint> WayPoints { get; }
    public IReadOnlyList<EscortPoint> EscortPoints { get; }
}
