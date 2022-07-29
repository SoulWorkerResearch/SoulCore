using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Drop)]
public enum DropOpcode : byte
{
    Infos = 0x1,
    PickUp = 0x2,
    Delete = 0x3,
}
