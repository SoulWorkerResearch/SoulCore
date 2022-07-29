namespace SoulWorkerResearch.SoulCore.Defines;

public enum BoosterEffectType : byte
{
    None = 0,
    IncExp = 1,
    IncItemDrop = 2,
    ReduceDec = 3,
    AddFP = 4,
    IncUpgradeItem = 5,
    IncGoldDrop = 6,
    IncEtherDrop = 7,
    IncBattlePoint = 8,
    Status = 9,
    MazeRewardIncExp = 0x0A,
    MazeRewardIncMoney = 0x0B,
    HiddenEvent = 0x0C,
    FatigueDecrease = 0x0D,
    IncExchangeCount = 0x0E,
    FreeExchangeCommission = 0x0F,
    IncExchangeExpire = 0x10,
    IncGroutonRate = 0x11,
    ReduceExchangeCommission = 0x12,
    CompleteQuestIncExp = 0x13,
    Max = 0x14,
}
