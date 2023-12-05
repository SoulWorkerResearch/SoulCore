using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Gesture)]
public enum GestureOpcode : byte
{
    Show = 0x1,
    SlotLoad = 0x2,
    SlotUpdate = 0x3
}
