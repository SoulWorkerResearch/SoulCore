using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Xml;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VPortalBox : VEntity
    {
        /// <summary>
        /// Visible of GUI(True or False)
        /// </summary>
        public bool ShowGui { get; set; }

        /// <summary>
        /// tb_Maze_Entry_Gui
        /// </summary>
        public uint Gui { get; set; }

        /// <summary>
        /// moving type
        /// </summary>
        public JumpType JumpType { get; set; }

        /// <summary>
        /// Jump map ID
        /// </summary>
        public uint JumpMap { get; set; }

        /// <summary>
        /// m_ID of VStartEventBox be moved
        /// </summary>
        public uint Jump { get; set; }

        /// <summary>
        /// An initial activation state of the portal(Enable of Disable)
        /// </summary>
        public PortalState PortalState { get; set; }

        /// <summary>
        /// Output of the non-active state VFX resource path
        /// </summary>
        public string DisableEffect { get; set; }

        /// <summary>
        /// Output of the active state VFX resource path
        /// </summary>
        public string EnableEffect { get; set; }

        /// <summary>
        /// UI String
        /// </summary>
        public uint UiString { get; set; }

        /// <summary>
        /// ID of next sector
        /// </summary>
        public uint NextSector { get; set; }

        /// <summary>
        /// Will you call the script?
        /// </summary>
        public bool CallScript { get; set; }

        /// <summary>
        /// Hold or break the episode activation
        /// </summary>
        public uint OpenEpisode { get; set; }

        /// <summary>
        /// Deactivated upon completion of the episode
        /// </summary>
        public uint CompleteEpisode { get; set; }

        /// <summary>
        /// UI String Offset
        /// </summary>
        public Vector3 StringOffset { get; set; }

        /// <summary>
        /// ClearSector Id
        /// </summary>
        public List<uint> ClearSectors { get; set; }

        /// <summary>
        /// ClearSector Chance
        /// </summary>
        public List<float> ClearSectorChances { get; set; }

        /// <summary>
        /// MaxUserCount
        /// </summary>
        public uint MaxUserCount { get; set; }

        /// <summary>
        /// MaxTimeCount
        /// </summary>
        public uint MaxTimeCount { get; set; }

        internal VPortalBox(XmlNode xml) : base(xml)
        {
            ShowGui = xml.GetBool("m_bShowGUI");
            Gui = xml.GetUInt32("m_iGUI");
            JumpType = xml.GetEnum<JumpType>("m_eJumpType");
            JumpMap = xml.GetUInt32("m_iJumpMap");
            Jump = xml.GetUInt32("m_iJump");
            PortalState = xml.GetEnum<PortalState>("m_eEffectType");
            DisableEffect = xml.GetString("m_szDisableEffect");
            EnableEffect = xml.GetString("m_szEnableEffect");
            UiString = xml.GetUInt32("m_iUIString");
            NextSector = xml.GetUInt32("m_iNextSectorID");
            CallScript = xml.GetBool("m_bCallScript");
            OpenEpisode = xml.GetUInt32("m_uiOpenEpisode");
            CompleteEpisode = xml.GetUInt32("m_uiCompleteEpisode");
            StringOffset = new(xml.GetSingle("m_fStringOffsetX"), xml.GetSingle("m_fStringOffsetY"), xml.GetSingle("m_fStringOffsetZ"));
            ClearSectors = Enumerable.Range(1, 5).Select(id => xml.GetUInt32($"m_iClearSectorID{id}")).ToList();
            ClearSectorChances = Enumerable.Range(1, 5).Select(id => xml.GetSingle($"m_fClearSectorChance{id}")).ToList();
            MaxUserCount = xml.GetUInt32("m_iMaxUserCount");
            MaxTimeCount = xml.GetUInt32("m_iMaxTimeCount");
        }
    }
}
