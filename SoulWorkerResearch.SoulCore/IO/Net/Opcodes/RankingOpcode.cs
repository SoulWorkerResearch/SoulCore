using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Ranking)]
public enum RankingOpcode : byte
{
    List = 0x1,
    Reward = 0x2
}
