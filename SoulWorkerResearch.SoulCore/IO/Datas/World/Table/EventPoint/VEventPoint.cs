using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventPoint
{
    public sealed record VEventPoint
    {
        public readonly static VEventPoint Empty = new();

        public List<VWayPoint> WayPoints { get; set; } = new();
        public List<VEscortPoint> EscortPoints { get; set; } = new();

        public VEventPoint()
        {
        }

        public VEventPoint(XmlNode xml)
        {
            WayPoints = xml.SelectNodes("VWayPoint")?.Cast<XmlNode>().Select(v => new VWayPoint(v)).ToList() ?? new();
            EscortPoints = xml.SelectNodes("VEscortPoint")?.Cast<XmlNode>().Select(v => new VEscortPoint(v)).ToList() ?? new();
        }
    }
}
