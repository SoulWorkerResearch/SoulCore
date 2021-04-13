using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VSafeAreaBox : VEntity
    {
        internal VSafeAreaBox(XmlNode xml) : base(xml)
        {
        }
    }
}
