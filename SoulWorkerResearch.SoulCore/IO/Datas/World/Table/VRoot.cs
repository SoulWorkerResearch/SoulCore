using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventPoint;
using System;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table
{
    public sealed record VRoot
    {
        public readonly static VRoot Empty = new();

        public readonly VEventBox EventBox;
        public readonly VEventPoint EventPoint;

        internal VRoot(XmlNode xml)
        {
            EventBox = new(xml.SelectSingleNode("Batchs [@eventtype='EventBox']") ?? throw new ApplicationException());
            EventPoint = new(xml.SelectSingleNode("Batchs [@eventtype='EventPoint']") ?? throw new ApplicationException());
        }

        private VRoot()
        {
            EventBox = VEventBox.Empty;
            EventPoint = VEventPoint.Empty;
        }
    }
}