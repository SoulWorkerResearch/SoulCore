﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Maze)]
public enum MazeOpcode : byte
{
    EnterMazeReq = 0x1,
    SectorErrorCheck = 0x2,
    SectorErrorFix = 0x3,
    SectorLoadResource = 0x4,
    PlayEvent = 0x5,
    EnterMazePartyReq = 0x11,
    EnterMazePartyRes = 0x12,
    EnterMazePartyCalcel = 0x13,
    MonsterKillScore = 0x14,
    UpdateState = 0x21,
    CompleteMazeReq = 0x22,
    ExitMazeReq = 0x23,
    ExitMazeRes = 0x24,
    CompleteMazeStartGame = 0x25,
    EventSpawnBoxReq = 0x31,
    EventSpawnBoxReqBt = 0x32,
    EventSceneDirecting = 0x33,
    EventSceneDirectingBt = 0x34,
    CheckEventSpawnBoxReq = 0x35,
    CheckEventSpawnBoxBt = 0x36,
    HiddenEventInfo = 0x37,
    Timer = 0x38,
    EnterReq = 0x43,
    EnterRes = 0x44,
    WarpReq = 0x45,
    WarpRes = 0x46,
    EnterPartyReq = 0x47,
    EnterPartyRes = 0x48,
    CancelEnterParty = 0x49,
    AgreeEnterParty = 0x4A,
    EnterForceReq = 0x4B,
    EnterForceRes = 0x4C,
    CancelEnterForce = 0x4D,
    AgreeEnterForce = 0x4F,
    Notice = 0x51,
    SectorClear = 0x52,
    SectorInfos = 0x53,
    GateInfos = 0x54,
    PotalInfos = 0x55,
    InteractionInfos = 0x56,
    InteractionEnable = 0x57,
    MonsterHpchangeState = 0x58,
    UpdateUnityPoint = 0x59,
    LuaClientSync = 0x60,
    NpcTalkEndReq = 0x61,
    OperationEndReq = 0x62,
    WarpInSector = 0x63,
    ClearInfo = 0x64,
    QuestMoveCheckReq = 0x65,
    QuestMoveCheckRes = 0x66,
    EscortStatus = 0x67,
    DieMonsters = 0x68,
    ModeFail = 0x69,
    UseReviveCount = 0x70,
    MonsterClientSpawn = 0x71,
    TrapClientSpawn = 0x72,
    RewardForceInfo = 0x73,
    WarlordRewardInfo = 0x74,
    RewardInfo = 0x75,
    RewardPartyInfo = 0x76,
    InteractionClickReq = 0x77,
    InteractionRun = 0x78,
    InteractionMotion = 0x79,
    SwitchNpcEnable = 0x7A,
    SwitchNpcStatus = 0x7B,
    SwitchNpcClickReq = 0x7C,
    LuaFunctionReq = 0x7E,
    LuaFunctionRes = 0x7F,
}