using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Xml;

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

        public VServerGateBox()
        {
        }

        public VServerGateBox(XmlNode xml) : base(xml)
        {
            Type = xml.GetEnum<GateType>("m_eType");
            NextSector = xml.GetUInt32("m_iNextSectorID");
            Sector = xml.GetUInt32("m_iSectorID");
        }
    }
}
