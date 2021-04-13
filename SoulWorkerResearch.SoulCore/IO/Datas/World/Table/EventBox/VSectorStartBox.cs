using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VSectorStartBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public uint Sector { get; set; }

        public VSectorStartBox()
        {
        }

        internal VSectorStartBox(XmlNode xml) : base(xml) =>
            Sector = xml.GetUInt32("m_nSectorID");
    }
}