using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VQuestMoveCheckBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public uint EpisodeCondition { get; set; }

        public VQuestMoveCheckBox()
        {
        }

        public VQuestMoveCheckBox(XmlNode xml) : base(xml) =>
            EpisodeCondition = xml.GetUInt32("m_uiEpisodeCondition");
    }
}
