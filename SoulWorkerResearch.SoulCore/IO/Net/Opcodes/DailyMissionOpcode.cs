using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.DailyMission)]
public enum DailyMissionOpcode : byte
{
    List = 0x1,
    Accept = 0x2,
    Update = 0x3,
    Helper = 0x4,
    InitAll = 0x5
}
