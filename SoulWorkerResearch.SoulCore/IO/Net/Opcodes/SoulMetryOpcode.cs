﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.SoulMetry)]
public enum SoulMetryOpcode : byte
{
    List = 0x1,
    CompleteList = 0x2,
    Add = 0x3,
    Update = 0x4,
    Complete = 0x5,
    Reset = 0x6,
}
