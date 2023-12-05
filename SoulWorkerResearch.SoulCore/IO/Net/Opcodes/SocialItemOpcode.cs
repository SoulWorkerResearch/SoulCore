﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.SocialItem)]
public enum SocialItemOpcode : byte
{
    Start = 0x1,
    Use = 0x2,
    Stop = 0x3,
    End = 0x4,
    In = 0x5,
    Infos = 0x6,
    Out = 0x7,
    PlayStart = 0x8,
    PlayGame = 0x9,

    PlayUserInfo = 0x10
    //
}
