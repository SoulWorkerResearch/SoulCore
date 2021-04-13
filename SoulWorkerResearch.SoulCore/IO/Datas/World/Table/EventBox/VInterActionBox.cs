using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VInterActionBox : VEntity
    {
        /// <summary>
        /// Interactive table ID
        /// </summary>
        public uint Interaction { get; set; }

        /// <summary>
        /// Interactive ObjectKey
        /// </summary>
        public string ObjectKey { get; set; }

        internal VInterActionBox(XmlNode xml) : base(xml)
        {
            Interaction = xml.GetUInt32("m_iInteractionID");
            ObjectKey = xml.GetString("m_sObjectKey");
        }
    }
}
