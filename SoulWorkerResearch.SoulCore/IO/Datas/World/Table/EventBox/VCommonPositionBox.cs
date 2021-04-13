using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VCommonPositionBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public EntityType EntityType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public uint Entity { get; set; }

        /// <summary>
        ///
        /// </summary>
        public uint Group { get; set; }

        public VCommonPositionBox()
        {
        }

        public VCommonPositionBox(XmlNode xml) : base(xml)
        {
            EntityType = xml.GetEnum<EntityType>("m_eEntityType");
            Entity = xml.GetUInt32("m_iEntityID");
            Group = xml.GetUInt32("m_iGroup");
        }
    }
}
