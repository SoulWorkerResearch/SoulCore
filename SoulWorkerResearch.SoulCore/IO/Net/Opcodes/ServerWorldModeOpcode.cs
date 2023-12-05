using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.ServerWorldMode)]
public enum ServerWorldModeOpcode : byte
{
    Start = 0x1,
    Update = 0x2,
    Clear = 0x3,
    Finish = 0x4,
    Sync = 0x5,
    Command = 0x6,
    Complete = 0x7,
    Fail = 0x8,
    Enter = 0x9
}
