using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VSocialItemExcludeBox : VEntity
    {
        internal VSocialItemExcludeBox(XmlNode xml) : base(xml)
        {
        }
    }
}
