using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VSafeAreaBox : VEntity
    {
        public VSafeAreaBox()
        {
        }

        public VSafeAreaBox(XmlNode xml) : base(xml)
        {
        }
    }
}
