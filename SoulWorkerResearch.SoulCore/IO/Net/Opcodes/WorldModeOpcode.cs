using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.WorldMode)]
public enum WorldModeOpcode : byte
{
    Start = 0x1,
    Update = 0x2,
    Finish = 0x3,
    Rank = 0x4,
    Info = 0x5
}
