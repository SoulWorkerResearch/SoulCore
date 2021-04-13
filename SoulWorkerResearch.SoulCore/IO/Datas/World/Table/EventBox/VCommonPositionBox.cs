using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Xml;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;

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

        internal VCommonPositionBox(XmlNode xml) : base(xml)
        {
            EntityType = xml.GetEnum<EntityType>("m_eEntityType");
            Entity = xml.GetUInt32("m_iEntityID");
            Group = xml.GetUInt32("m_iGroup");
        }
    }
}
