using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Booster)]
public enum BoosterOpcode : byte
{
    ListLoad = 0x1,
    Add = 0x2,
    Remove = 0x3,
    Clear = 0x4
}
