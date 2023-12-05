using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct CharacterValue
{
    public int Id { get; init; }
    public string Name { get; init; }
    public Character Class { get; init; }
    public Advancement Advancement { get; init; }
    public int Photo { get; init; }
    public AppearanceValue Appearance { get; init; }
    public byte Level { get; init; }
    public byte Faction { get; init; }
    public int AccountId { get; init; }
    public Permisson Permission { get; init; }
    public int PvPKillCount { get; init; }
    public GearValue Weapon { get; init; }
    public GearValue SubWeapon { get; init; }
    public CostumeValues Costumes { get; init; }
    public int ActiveBroachEffect { get; init; }
    public TitleEntity Title { get; init; }
    public LeagueValue League { get; init; }
    public StatValues Stats { get; init; }
    public PrivateShopValue Shop { get; init; }
    public FatiguePointValue Fp { get; init; }
    public EchelonValue Echelon { get; init; }
    public byte BattlePose { get; init; }
    public int Status { get; init; }
    public IEnumerable<BuffValue> Buffs { get; init; }
    public byte Slot { get; init; }
    public int EqualizerId { get; init; }
    public int _1 { get; init; }
    public byte _2 { get; init; }
    public int _3 { get; init; }

    internal CharacterValue(BinaryReader reader)
    {
        Id = reader.ReadInt32();
        Name = reader.ReadUTF16UnicodeString();
        Class = reader.ReadClass();
        Advancement = reader.ReadClassAdvancement();
        Photo = reader.ReadInt32();
        Appearance = new AppearanceValue(reader);
        Level = reader.ReadByte();
        Faction = reader.ReadByte();
        AccountId = reader.ReadInt32();
        Permission = reader.ReadPermission();
        PvPKillCount = reader.ReadInt32();
        Weapon = new GearValue(reader);
        SubWeapon = new GearValue(reader);
        Costumes = new CostumeValues(reader);
        ActiveBroachEffect = reader.ReadInt32();
        Title = new TitleEntity(reader);
        League = new LeagueValue(reader);
        Stats = new StatValues(reader);
        Shop = new PrivateShopValue(reader);
        Fp = new FatiguePointValue(reader);
        Echelon = new EchelonValue(reader);
        BattlePose = reader.ReadByte();
        Status = reader.ReadInt32();
        Buffs = Enumerable.Range(0, reader.ReadByte()).Select(_ => new BuffValue(reader)).ToArray();
        Slot = reader.ReadByte();
        EqualizerId = reader.ReadInt32();
        _1 = reader.ReadInt32();
        _2 = reader.ReadByte();
        _3 = reader.ReadInt32();
    }
}
