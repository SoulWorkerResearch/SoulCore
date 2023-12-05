﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Character)]
public enum CharacterOpcode : byte
{
    CreateReq = 0x1,
    DeleteReq = 0x2,
    DeleteRes = 0x3,
    KickOut = 0x4,
    PacketStepCheck = 0x5,
    ChangeSlot = 0x6,
    UpdateAwaken = 0x7,
    UpdateFreeRevive = 0x8,
    ProfilePhotoLoad = 0x9,
    ProfilePhotoUpdate = 0xA,
    ProfilePhotoFavorite = 0xb,
    ProfilePhotoChange = 0xC,
    RepresentativeCheck = 0xD,
    RepresentativeChange = 0xF,
    ListReq = 0x11,
    ListRes = 0x12,
    SelectReq = 0x13,
    SelectRes = 0x14,
    EnterPrologue = 0x15,
    EnterBattleZone = 0x16,
    SecondPassword = 0x17,
    TradePassword = 0x18,
    UpdateCutscene = 0x19,
    PlayCutscene = 0x20,
    EnterGameServerReq = 0x21,
    EnterGameServerRes = 0x22,
    LoadTitle = 0x23,
    AddTitle = 0x24,
    UpdateTitle = 0x25,
    UpdateTitleBt = 0x26,
    ClearTitle = 0x27,
    DeleteTitle = 0x28,
    UpdateOpenTitle = 0x29,
    FavoriteTitle = 0x2A,
    ChangeBackground = 0x2C,
    AddBackground = 0x2B,
    DbLoadSync = 0x30,
    InfoReq = 0x31,
    InfoRes = 0x32,
    SaveReq = 0x33,
    UpdateStatList = 0x34,
    UpdateStat = 0x35,
    Level = 0x36,
    Exp = 0x37,
    Money = 0x38,
    HeartBeat = 0x39,
    CheckEnterMaze = 0x40,
    Die = 0x41,
    ReviveReq = 0x42,
    ReviveRes = 0x43,
    ReviveBt = 0x44,
    ChangeMotionReq = 0x45,
    ChangeMotionBt = 0x46,
    UpdateSpecialOptionList = 0x47,
    ReserveReviveBt = 0x48,
    ReserveReviveReq = 0x49,
    UpdateOriginStat = 0x51,
    UpdateEchelonInfo = 0x52,
    UpdateEchelonBt = 0x53,
    UpdateNetcafe = 0x54,
    CheckName = 0x57,
    UpdateSharePoint = 0x58,
    ResetSharePoint = 0x59,
    GobackLobby = 0x60,
    LoadDistrictState = 0x61,
    LoadMazeState = 0x62,
    GetRewardSharePoint = 0x63,
    FpUpdate = 0x64,
    NpcCreditLoad = 0x65,
    NpcCreditUpdate = 0x66,
    NpcCreditInit = 0x67,
    OtherInfoRefuse = 0x68,
    AchieveSelect = 0x70,
    AchieveUpdate = 0x71,
    AchieveComplete = 0x72,
    AchieveReset = 0x73,
    AchieveReward = 0x74,
    OtherInfo = 0x75,
    ClassScene = 0x76,
    Community = 0x77,
    LeagueWithdrawPenalty = 0x78,
    LeagueDeletePenalty = 0x79,
    EqualizerUpdate = 0x7A,
    CashMileageInfo = 0x7B
}
