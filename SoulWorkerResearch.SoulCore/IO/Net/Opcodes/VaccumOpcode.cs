using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Vaccum)]
public enum VaccumOpcode : byte
{
    ClickStart = 0x1,
    ClickCancel = 0x2,
    ClickComplete = 0x3,
    In = 0x11,
    Out = 0x12,
    Infos = 0x13
}
