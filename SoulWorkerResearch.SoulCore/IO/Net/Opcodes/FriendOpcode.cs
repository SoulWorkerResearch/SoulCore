﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Friend)]
public enum FriendOpcode : byte
{
    Load = 0x1,
    BlocklistLoad = 0x2,
    Invite = 0x11,
    InviteReq = 0x12,
    InviteAccept = 0x13,
    Add = 0x14,
    Delete = 0x15,
    BlocklistAdd = 0x21,
    BlocklistDelete = 0x22,
    UpdateInfo = 0x31,
    Info = 0x32,
    Find = 0x33,
    RecruitList = 0x41,
    RecruitAdd = 0x42,
    RecruitDelete = 0x43,
    RecruitInfo = 0x44,
    RecommandList = 0x51,
    Message = 0x61,
    Clear = 0x62,
    ClearBlocklist = 0x63,
}
