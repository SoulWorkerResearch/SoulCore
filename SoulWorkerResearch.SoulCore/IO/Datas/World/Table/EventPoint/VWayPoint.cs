using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventPoint
{
    public sealed record VWayPoint : VPoint
    {
        public VWayPoint()
        {
        }

        internal VWayPoint(XmlNode xml) : base(xml)
        {
        }
    }
}