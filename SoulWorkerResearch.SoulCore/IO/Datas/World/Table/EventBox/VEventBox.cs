using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VEventBox
    {
        public static readonly VEventBox Empty = new();

        public readonly List<VSectorBox> Sectors;
        public readonly List<VMonsterSpawnBox> MonsterSpawns;
        public readonly List<VStartEventBox> StartEvents;
        public readonly List<VPortalExitBox> PortalExits;
        public readonly List<VPortalBox> Portals;
        public readonly List<VMazeEscapeBox> MazeEscapes;
        public readonly List<VSectorStartBox> SectorStarts;
        public readonly List<VSocialItemExcludeBox> SocialItemExcludes;
        public readonly List<VLuaFunctionBox> LuaFunctions;
        public readonly List<VSafeAreaBox> SafeAreas;
        public readonly List<VPersonalShopAreaBox> PersonalShopAreas;
        public readonly List<VInterActionBox> InterActions;
        public readonly List<VCheckMonsterSpawnBox> CheckMonsterSpawns;
        public readonly List<VCommonPositionBox> CommonPositions;
        public readonly List<VCheckSectorBox> CheckSectors;
        public readonly List<VServerGateBox> ServerGates;
        public readonly List<VQuestMoveCheckBox> QuestMoveChecks;
        public readonly List<VCheckEventSpawnBox> CheckEventSpawns;

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

        private VEventBox()
        {
            Sectors = new();
            MonsterSpawns = new();
            StartEvents = new();
            PortalExits = new();
            Portals = new();
            MazeEscapes = new();
            SectorStarts = new();
            SocialItemExcludes = new();
            LuaFunctions = new();
            SafeAreas = new();
            PersonalShopAreas = new();
            InterActions = new();
            CheckMonsterSpawns = new();
            CommonPositions = new();
            CheckSectors = new();
            ServerGates = new();
            QuestMoveChecks = new();
            CheckEventSpawns = new();
        }
    }
}
