using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VCheckSectorBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public uint CheckSector { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Lua { get; set; } = string.Empty;

        /// <summary>
        ///
        /// </summary>
        public uint CheckGate { get; set; }

        public VCheckSectorBox()
        {
        }

        public VCheckSectorBox(XmlNode xml) : base(xml)
        {
            CheckSector = xml.GetUInt32("m_iCheckSector");
            Lua = xml.GetString("m_szLua");
            CheckGate = xml.GetUInt32("m_iCheckGate");
        }
    }
}
