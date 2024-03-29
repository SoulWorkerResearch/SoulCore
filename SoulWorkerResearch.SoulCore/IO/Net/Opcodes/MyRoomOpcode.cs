﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.MyRoom)]
public enum MyRoomOpcode : byte
{
    Load = 0x1,
    EditStart = 0x5,
    EditEnd = 0x6,
    CreateReq = 0x10,
    EnterReq = 0x11,
    LoadIndex = 0x12,
    ExitReq = 0x13,
    Setup = 0x14,
    KickOut = 0x15,
    ItemAdd = 0x20,
    ItemDel = 0x21,
    ItemUse = 0x22,
    ItemReleaseUsed = 0x23,
    ItemUsedUsers = 0x24,
    OutReason = 0x25,
    DoorState = 0x26,
    DoorStateList = 0x27,
    PollenLoad = 0x30,
    PollenAdd = 0x31,
    PollenCultivation = 0x32,
    PollenHarvest = 0x33,
    PollenHelp = 0x34,
    PollenItemUse = 0x35,
    PollenUpdate = 0x36,
    PollenCancel = 0x37,
    PollenLook = 0x38,
    PollenHarvestResult = 0x39,
    Recommend = 0x40,
    Favorite = 0x41,
    WriteBoard = 0x42,
    WriteInfo = 0x43,
    BoardList = 0x44,
    RankInfo = 0x46,
    FavoriteInfo = 0x47,
    RankReward = 0x48,
}
