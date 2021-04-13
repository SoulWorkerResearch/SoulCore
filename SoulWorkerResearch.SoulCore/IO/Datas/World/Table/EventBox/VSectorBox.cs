using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VSectorBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public SectorType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string EnterLua { get; set; } = string.Empty;

        /// <summary>
        ///
        /// </summary>
        public ClearType ClearType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public byte ClearKillRatio { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string ClearLua { get; set; } = string.Empty;

        /// <summary>
        /// Title to be displayed on the screen when entering the sector
        /// </summary>
        public uint SectorTitle { get; set; }

        /// <summary>
        /// Type of exit sector
        /// </summary>
        public SectorExitType ExitType { get; set; }

        /// <summary>
        /// ID of exit sector
        /// </summary>
        public uint Exit { get; set; }

        /// <summary>
        /// ID of ralative sector(for monster spwan)
        /// </summary>
        public uint RelativeSector { get; set; }

        /// <summary>
        /// Sectors within the monster kill ratio step
        /// </summary>
        public List<byte> ConditionKillRatioSteps { get; set; } = new();

        public VSectorBox()
        {
        }

        public VSectorBox(XmlNode xml) : base(xml)
        {
            Type = xml.GetEnum<SectorType>("m_eType");
            EnterLua = xml.GetString("m_szEnterLua");
            ClearType = xml.GetEnum<ClearType>("m_eClearType");
            ClearKillRatio = xml.GetByte("m_iClearKillRatio");
            ClearLua = xml.GetString("m_szClearLua");
            SectorTitle = xml.GetUInt32("m_iSectorTitle");
            ExitType = xml.GetEnum<SectorExitType>("m_iSectorExitType");
            Exit = xml.GetUInt32("m_iSectorExitID");
            RelativeSector = xml.GetUInt32("m_iRelativeSectorID");
            ConditionKillRatioSteps = Enumerable.Range(1, 5).Select(id => xml.GetByte($"m_iConditionKillRatio_{id}Step")).ToList();
        }
    }
}
