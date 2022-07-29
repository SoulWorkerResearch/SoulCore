using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Channel)]
public enum ChannelOpcode : byte
{
    Info = 0x1,
    Change = 0x2,
}
