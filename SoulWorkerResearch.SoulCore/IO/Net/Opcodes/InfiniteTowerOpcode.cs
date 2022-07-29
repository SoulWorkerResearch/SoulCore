using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.InfiniteTower)]
public enum InfiniteTowerOpcode : byte
{
    LoadInfo = 0x1,
    EnterChapter = 0x2,
    EnterNextStage = 0x3,
    Reward = 0x4,
}
