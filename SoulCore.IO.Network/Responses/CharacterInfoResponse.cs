using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.PacketSharedStructure;
using System;

namespace SoulCore.IO.Network.Responses
{
    [Flags]
    public enum SyncUserFlags
    {
        None = 0,
        SyncCharacter = 1 << 0,
        SyncInven = 1 << 1,
        SyncQuest = 1 << 2,
        SyncSoulmetry = 1 << 3,
        SyncWorld = 1 << 4,
        SyncQuickSlot = 1 << 5,
        SyncBlockList = 1 << 6,
        SyncBank = 1 << 7,
        SyncAchieve = 1 << 8,
        SyncFriendList = 1 << 9,
        SyncItemExchange = 1 << 10,
        SyncGesture = 1 << 11,
        SyncTitle = 1 << 12,
        SyncFurniture = 1 << 13,
        SyncCashInfo = 1 << 14,
        SyncParty = 1 << 15,
        SyncAppearance = 1 << 16,
        SyncAkashicRecord = 1 << 17,
        SyncUseInfo = 1 << 18,
        SyncNpcCredit = 1 << 19,
        SyncShopItem = 1 << 20,
        SyncCharCommunity = 1 << 21,
        SyncPostRecvInfo = 1 << 22,
        SyncPostSendInfo = 1 << 23,
        SyncPostSaveInfo = 1 << 24,
        SyncPostAccountInfo = 1 << 25,
        SyncPollenInfo = 1 << 26,
        SyncMyRoom = 1 << 27,
        SyncNetCafe = 1 << 28,
        SyncSGAuth = 1 << 29,
    }

    [Flags]
    public enum UserFlags
    {
        Null = 0,
        LoadCharacter = 1 << 0,
        LoadInven = 1 << 1,
        LoadQuest = 1 << 2,
        LoadSoulmetry = 1 << 3,
        LoadWorld = 1 << 4,
        LoadQuickSlot = 1 << 5,
        LoadBlockList = 1 << 6,
        LoadBank = 1 << 7,
        LoadFriendList = 1 << 8,
        LoadFriendServer = 1 << 9,
        LoadItemExchange = 1 << 10,
        LoadGesture = 1 << 11,
        LoadTitle = 1 << 12,
        LoadFurniture = 1 << 13,
        LoadParty = 1 << 14,
        LoadForce = 1 << 15,
        LoadAchieve = 1 << 16,
        LoadAkashicRecord = 1 << 17,
        SocketInfo = 1 << 18,
        BroachInfo = 1 << 19,
        LoadUseInfo = 1 << 20,
        LoadNpcCredit = 1 << 21,
        LoadShopItem = 1 << 22,
        LoadCashCount = 1 << 23,
        LoadCashSet = 1 << 24,
        LoadAppearance = 1 << 25,
        LoadCharCommunity = 1 << 26,
        Load_ALL = 1 << 27,
        LoadPostInfo = 1 << 28,
        LoadDailyMission = 1 << 29,
        LoadMyRoom = 1 << 30,
        LoadLevelUpEvent = 1 << 31,
        // LoadNetCafe = 1 << 32,
        // LoadSGAuth = 1 << 33,
        // LoadGFAuth = 1 << 34,
        // LoadWMAuth = 1 << 35,
        // PackageInfo = 1 << 36,
    };

    [Response(CategoryCommand.Character, CharacterCommand.InfoRes)]
    public readonly struct CharacterInfoResponse
    {
        public readonly CharacterExPacketSharedStructure Character { get; init; }
        public readonly long Exp { get; init; }
        public readonly long Money { get; init; }
        public readonly byte CommonStep { get; init; }
        public readonly byte ConsumeStep { get; init; }
        public readonly byte CostumeStep { get; init; }
        public readonly byte CardStep { get; init; }
        public readonly UserFlags UserFlags { get; init; }
        public readonly SyncUserFlags SyncUserFlags { get; init; }
        public readonly long BattlePoint { get; init; }
        public readonly long Ether { get; init; }
        public readonly long FriendPoint { get; init; }
        public readonly string AccountId { get; init; }
        public readonly bool NetCafe { get; init; }
        public readonly long Recycle { get; init; }
        public readonly int DyePoint { get; init; }
        public readonly int RenovatePoint { get; init; }
        public readonly int RefinePoint { get; init; }
        public readonly byte _1 { get; init; }
        public readonly bool WorldIdGreaterThan20000 { get; init; }
        public readonly bool PvPEnabled { get; init; }
    }
}