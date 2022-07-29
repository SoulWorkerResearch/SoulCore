using System.Xml.Linq;
using System.Xml.XPath;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record EventBox
{
    public IReadOnlyList<SectorBox> Sectors { get; }
    public IReadOnlyList<MonsterSpawnBox> MonsterSpawns { get; }
    public IReadOnlyList<StartEventBox> StartEvents { get; }
    public IReadOnlyList<PortalExitBox> PortalExits { get; }
    public IReadOnlyList<PortalBox> Portals { get; }
    public IReadOnlyList<MazeEscapeBox> MazeEscapes { get; }
    public IReadOnlyList<SectorStartBox> SectorStarts { get; }
    public IReadOnlyList<SocialItemExcludeBox> SocialItemExcludes { get; }
    public IReadOnlyList<LuaFunctionBox> LuaFunctions { get; }
    public IReadOnlyList<SafeAreaBox> SafeAreas { get; }
    public IReadOnlyList<PersonalShopAreaBox> PersonalShopAreas { get; }
    public IReadOnlyList<InterActionBox> InterActions { get; }
    public IReadOnlyList<CheckMonsterSpawnBox> CheckMonsterSpawns { get; }
    public IReadOnlyList<CommonPositionBox> CommonPositions { get; }
    public IReadOnlyList<CheckSectorBox> CheckSectors { get; }
    public IReadOnlyList<ServerGateBox> ServerGates { get; }
    public IReadOnlyList<QuestMoveCheckBox> QuestMoveChecks { get; }
    public IReadOnlyList<CheckEventSpawnBox> CheckEventSpawns { get; }

    public EventBox(XElement x)
    {
        Sectors = x.XPathSelectElements("VSectorBox").Select(v => new SectorBox(v)).ToArray();
        MonsterSpawns = x.XPathSelectElements("VMonsterSpawnBox").Select(v => new MonsterSpawnBox(v)).ToArray();
        StartEvents = x.XPathSelectElements("VStartEventBox").Select(v => new StartEventBox(v)).ToArray();
        PortalExits = x.XPathSelectElements("VPortalExitBox").Select(v => new PortalExitBox(v)).ToArray();
        Portals = x.XPathSelectElements("VPortalBox").Select(v => new PortalBox(v)).ToArray();
        MazeEscapes = x.XPathSelectElements("VMazeEscapeBox").Select(v => new MazeEscapeBox(v)).ToArray();
        SectorStarts = x.XPathSelectElements("VSectorStartBox").Select(v => new SectorStartBox(v)).ToArray();
        SocialItemExcludes = x.XPathSelectElements("VSocialItemExcludeBox").Select(v => new SocialItemExcludeBox(v)).ToArray();
        LuaFunctions = x.XPathSelectElements("VLuaFunctionBox").Select(v => new LuaFunctionBox(v)).ToArray();
        SafeAreas = x.XPathSelectElements("VSafeAreaBox").Select(v => new SafeAreaBox(v)).ToArray();
        PersonalShopAreas = x.XPathSelectElements("VPersonalShopAreaBox").Select(v => new PersonalShopAreaBox(v)).ToArray();
        InterActions = x.XPathSelectElements("VInterActionBox").Select(v => new InterActionBox(v)).ToArray();
        CheckMonsterSpawns = x.XPathSelectElements("VCheckMonsterSpawnBox").Select(v => new CheckMonsterSpawnBox(v)).ToArray();
        CommonPositions = x.XPathSelectElements("VCommonPositionBox").Select(v => new CommonPositionBox(v)).ToArray();
        CheckSectors = x.XPathSelectElements("VCheckSectorBox").Select(v => new CheckSectorBox(v)).ToArray();
        ServerGates = x.XPathSelectElements("VServerGateBox").Select(v => new ServerGateBox(v)).ToArray();
        QuestMoveChecks = x.XPathSelectElements("VQuestMoveCheckBox").Select(v => new QuestMoveCheckBox(v)).ToArray();
        CheckEventSpawns = x.XPathSelectElements("VCheckEventSpawnBox").Select(v => new CheckEventSpawnBox(v)).ToArray();
    }
}
