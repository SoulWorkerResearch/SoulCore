using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.ItemUpgrade)]
public enum ItemUpgradeOpcode : byte
{
    Ok = 0x1,
    AddOptionOk = 0x2,
    MixOptionOk = 0x3,
}
