﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Party)]
public enum PartyOpcode : byte
{
    Invite = 0x1,
    Accept = 0x2,
    ChangeMaster = 0x3,
    KickOut = 0x4,
    Leave = 0x5,
    UpdateMemberInfo = 0x6,
    Delete = 0x7,
    Cancel = 0x8,
    UpdateInfo = 0x9,
    AddMember = 0x10,
    RemoveMember = 0x11,
    UpdateMemberHp = 0x12,
    UpdateMemberSg = 0x13,
    Message = 0x20,
    MatchingEnter = 0x30,
    MatchingExit = 0x31,
    MatchingCheck = 0x32,
    MatchingReset = 0x33,
    MatchingWait = 0x34,
    MazeClear = 0x35,
    RecruitList = 0x36,
    RecruitMyApplyList = 0x37,
    RecruitAdd = 0x38,
    RecruitApply = 0x39,
    RecruitApplyAccept = 0x3A,
    RecruitApplyReject = 0x3B,
    RecruitApplyUpdate = 0x3C,
    RecruitDel = 0x3D,
    RecruitApplyList = 0x3E,
    RecruitInfo = 0x3F,
    RecruitApplyDel = 0x40,
    RecruitApplyInfo = 0x41,
    RecuritApplyNotice = 0x42,
}
