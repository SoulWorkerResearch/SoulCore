using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.WeeklyMission)]
public enum WeeklyMissionOpcode : byte
{
    Info = 0x1,
    Update = 0x2,
    Reward = 0x3,
    RewardWeek = 0x4,
}
