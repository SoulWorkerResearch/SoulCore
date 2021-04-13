using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VPortalExitBox : VEntity
    {
        /// <summary>
        /// PortalBox ID of connected
        /// </summary>
        public uint ParentPortal { get; set; }

        internal VPortalExitBox(XmlNode xml) : base(xml) =>
            ParentPortal = xml.GetUInt32("m_iParentPortalBoxID");
    }
}
