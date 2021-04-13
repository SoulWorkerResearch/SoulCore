using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VMazeEscapeBox : VEntity
    {
        /// <summary>
        /// Field ID
        /// </summary>
        public uint Field { get; set; }

        /// <summary>
        /// ID of Event Object.
        /// </summary>
        public uint EventObject { get; set; }

        public VMazeEscapeBox()
        {
        }

        public VMazeEscapeBox(XmlNode xml) : base(xml)
        {
            Field = xml.GetUInt32("m_iField");
            EventObject = xml.GetUInt32("m_iEventObject");
        }
    }
}
