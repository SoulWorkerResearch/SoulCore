using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VPersonalShopAreaBox : VEntity
    {
        public VPersonalShopAreaBox()
        {
        }

        internal VPersonalShopAreaBox(XmlNode xml) : base(xml)
        {
        }
    }
}