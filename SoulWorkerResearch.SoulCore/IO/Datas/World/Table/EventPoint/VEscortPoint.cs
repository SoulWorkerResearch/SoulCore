using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventPoint
{
    public sealed record VEscortPoint : VPoint
    {
        /// <summary>
        ///
        /// </summary>
        public string Function { get; set; } = string.Empty;

        /// <summary>
        ///
        /// </summary>
        public string EnableEffectPath { get; set; } = string.Empty;

        /// <summary>
        ///
        /// </summary>
        public string DisableEffectPath { get; set; } = string.Empty;

        public VEscortPoint()
        {
        }

        public VEscortPoint(XmlNode xml) : base(xml)
        {
            Function = xml.GetString("m_szFunction");
            EnableEffectPath = xml.GetString("m_sEnableEffectPath");
            DisableEffectPath = xml.GetString("m_sDisableEffectPath");
        }
    }
}
