using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VEventBox
    {
        public static readonly VEventBox Empty = new();

        public List<VSectorBox> Sectors { get; set; } = new();
        public List<VMonsterSpawnBox> MonsterSpawns { get; set; } = new();
        public List<VStartEventBox> StartEvents { get; set; } = new();
        public List<VPortalExitBox> PortalExits { get; set; } = new();
        public List<VPortalBox> Portals { get; set; } = new();
        public List<VMazeEscapeBox> MazeEscapes { get; set; } = new();
        public List<VSectorStartBox> SectorStarts { get; set; } = new();
        public List<VSocialItemExcludeBox> SocialItemExcludes { get; set; } = new();
        public List<VLuaFunctionBox> LuaFunctions { get; set; } = new();
        public List<VSafeAreaBox> SafeAreas { get; set; } = new();
        public List<VPersonalShopAreaBox> PersonalShopAreas { get; set; } = new();
        public List<VInterActionBox> InterActions { get; set; } = new();
        public List<VCheckMonsterSpawnBox> CheckMonsterSpawns { get; set; } = new();
        public List<VCommonPositionBox> CommonPositions { get; set; } = new();
        public List<VCheckSectorBox> CheckSectors { get; set; } = new();
        public List<VServerGateBox> ServerGates { get; set; } = new();
        public List<VQuestMoveCheckBox> QuestMoveChecks { get; set; } = new();
        public List<VCheckEventSpawnBox> CheckEventSpawns { get; set; } = new();

        public VEventBox()
        {
        }

        internal VEventBox(XmlNode xml)
        {
            Sectors = xml.SelectNodes("VSectorBox")?.Cast<XmlNode>().Select(v => new VSectorBox(v)).ToList() ?? new();
            MonsterSpawns = xml.SelectNodes("VMonsterSpawnBox")?.Cast<XmlNode>().Select(v => new VMonsterSpawnBox(v)).ToList() ?? new();
            StartEvents = xml.SelectNodes("VStartEventBox")?.Cast<XmlNode>().Select(v => new VStartEventBox(v)).ToList() ?? new();
            PortalExits = xml.SelectNodes("VPortalExitBox")?.Cast<XmlNode>().Select(v => new VPortalExitBox(v)).ToList() ?? new();
            Portals = xml.SelectNodes("VPortalBox")?.Cast<XmlNode>().Select(v => new VPortalBox(v)).ToList() ?? new();
            MazeEscapes = xml.SelectNodes("VMazeEscapeBox")?.Cast<XmlNode>().Select(v => new VMazeEscapeBox(v)).ToList() ?? new();
            SectorStarts = xml.SelectNodes("VSectorStartBox")?.Cast<XmlNode>().Select(v => new VSectorStartBox(v)).ToList() ?? new();
            SocialItemExcludes = xml.SelectNodes("VSocialItemExcludeBox")?.Cast<XmlNode>().Select(v => new VSocialItemExcludeBox(v)).ToList() ?? new();
            LuaFunctions = xml.SelectNodes("VLuaFunctionBox")?.Cast<XmlNode>().Select(v => new VLuaFunctionBox(v)).ToList() ?? new();
            SafeAreas = xml.SelectNodes("VSafeAreaBox")?.Cast<XmlNode>().Select(v => new VSafeAreaBox(v)).ToList() ?? new();
            PersonalShopAreas = xml.SelectNodes("VPersonalShopAreaBox")?.Cast<XmlNode>().Select(v => new VPersonalShopAreaBox(v)).ToList() ?? new();
            InterActions = xml.SelectNodes("VInterActionBox")?.Cast<XmlNode>().Select(v => new VInterActionBox(v)).ToList() ?? new();
            CheckMonsterSpawns = xml.SelectNodes("VCheckMonsterSpawnBox")?.Cast<XmlNode>().Select(v => new VCheckMonsterSpawnBox(v)).ToList() ?? new();
            CommonPositions = xml.SelectNodes("VCommonPositionBox")?.Cast<XmlNode>().Select(v => new VCommonPositionBox(v)).ToList() ?? new();
            CheckSectors = xml.SelectNodes("VCheckSectorBox")?.Cast<XmlNode>().Select(v => new VCheckSectorBox(v)).ToList() ?? new();
            ServerGates = xml.SelectNodes("VServerGateBox")?.Cast<XmlNode>().Select(v => new VServerGateBox(v)).ToList() ?? new();
            QuestMoveChecks = xml.SelectNodes("VQuestMoveCheckBox")?.Cast<XmlNode>().Select(v => new VQuestMoveCheckBox(v)).ToList() ?? new();
            CheckEventSpawns = xml.SelectNodes("VCheckEventSpawnBox")?.Cast<XmlNode>().Select(v => new VCheckEventSpawnBox(v)).ToList() ?? new();
        }
    }
}