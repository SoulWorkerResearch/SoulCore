using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Restart)]
public enum RestartOpcode : byte
{
    Update = 0x1,
    Start = 0x2
}
