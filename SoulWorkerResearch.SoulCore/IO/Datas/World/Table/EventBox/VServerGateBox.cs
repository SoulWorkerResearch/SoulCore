using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Xml;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VServerGateBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public GateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        public uint NextSector { get; set; }

        /// <summary>
        ///
        /// </summary>
        public uint Sector { get; set; }

        internal VServerGateBox(XmlNode xml) : base(xml)
        {
            Type = xml.GetEnum<GateType>("m_eType");
            NextSector = xml.GetUInt32("m_iNextSectorID");
            Sector = xml.GetUInt32("m_iSectorID");
        }
    }
}
