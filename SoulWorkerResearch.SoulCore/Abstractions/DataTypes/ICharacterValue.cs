using SoulWorkerResearch.SoulCore.Defines;

namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface ICharacterValue
{
    int Id { get; }
    string Name { get; }
    Class Class { get; }
    ClassAdvancement Advancement { get; }
    uint Photo { get; }
    IAppearanceValue Appearance { get; }
    byte Level { get; }
    byte Faction { get; }
    int AccountId { get; }
    Permisson Permission { get; }
    int PvPKillCount { get; }
    IGearValue Weapon { get; }
    IGearValue SubWeapon { get; }
    ICostumeValues Costumes { get; }
    uint ActiveBroachEffect { get; }
    ITitleValue Title { get; }
    ILeagueValue League { get; }
    IStatValues Stats { get; }
    IPrivateShopValue Shop { get; }
    IFpValue Fp { get; }
    IEchelonValue Echelon { get; }
    byte BattlePose { get; }
    uint Status { get; }
    IEnumerable<IBuffValue> Buffs { get; }
    byte Slot { get; }
    int EqualizerId { get; }
}
