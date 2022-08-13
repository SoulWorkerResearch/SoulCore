using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct CharacterValue : ICharacterValue
{
    public static CharacterValue Empty { get; } = new();

    #region Body

    public int Id { get; init; }
    public string Name { get; init; }
    public Class Class { get; init; }
    public ClassAdvancement Advancement { get; init; }
    public uint Photo { get; init; }
    public AppearanceValue Appearance { get; init; }
    public byte Level { get; init; }
    public byte Faction { get; init; }
    public int AccountId { get; init; }
    public Permisson Permission { get; init; }
    public int PvPKillCount { get; init; }
    public GearValue Weapon { get; init; }
    public GearValue SubWeapon { get; init; }
    public CostumeValues Costumes { get; init; }
    public uint ActiveBroachEffect { get; init; }
    public TitleValue Title { get; init; }
    public LeagueValue League { get; init; }
    public StatValues Stats { get; init; }
    public PrivateShopValue Shop { get; init; }
    public FpValue Fp { get; init; }
    public EchelonValue Echelon { get; init; }
    public byte BattlePose { get; init; }
    public uint Status { get; init; }
    public IEnumerable<BuffValue> Buffs { get; init; }
    public byte Slot { get; init; }
    public int EqualizerId { get; init; }
    public int _1 { get; init; }
    public byte _2 { get; init; }
    public int _3 { get; init; }

    #endregion Body

    #region Constructors

    internal CharacterValue(BinaryReader reader)
    {
        Id = reader.ReadInt32();
        Name = reader.ReadUTF16UnicodeString();
        Class = reader.ReadClass();
        Advancement = reader.ReadClassAdvancement();
        Photo = reader.ReadUInt32();
        Appearance = new(reader);
        Level = reader.ReadByte();
        Faction = reader.ReadByte();
        AccountId = reader.ReadInt32();
        Permission = reader.ReadPermission();
        PvPKillCount = reader.ReadInt32();
        Weapon = new(reader);
        SubWeapon = new(reader);
        Costumes = new(reader);
        ActiveBroachEffect = reader.ReadUInt32();
        Title = new(reader);
        League = new(reader);
        Stats = new(reader);
        Shop = new(reader);
        Fp = new(reader);
        Echelon = new(reader);
        BattlePose = reader.ReadByte();
        Status = reader.ReadUInt32();
        Buffs = Enumerable.Range(0, reader.ReadByte()).Select(_ => new BuffValue(reader)).ToArray();
        Slot = reader.ReadByte();
        EqualizerId = reader.ReadInt32();
        _1 = reader.ReadInt32();
        _2 = reader.ReadByte();
        _3 = reader.ReadInt32();
    }

    #endregion Constructors

    #region ICharacterValue

    IAppearanceValue ICharacterValue.Appearance => Appearance;
    IGearValue ICharacterValue.Weapon => Weapon;
    IGearValue ICharacterValue.SubWeapon => SubWeapon;
    ICostumeValues ICharacterValue.Costumes => Costumes;
    ITitleValue ICharacterValue.Title => Title;
    ILeagueValue ICharacterValue.League => League;
    IStatValues ICharacterValue.Stats => Stats;
    IPrivateShopValue ICharacterValue.Shop => Shop;
    IFpValue ICharacterValue.Fp => Fp;
    IEchelonValue ICharacterValue.Echelon => Echelon;
    IEnumerable<IBuffValue> ICharacterValue.Buffs => Buffs.Cast<IBuffValue>();

    #endregion ICharacterValue

    #region IBinarySerializable

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Id);
        writer.Write(Name);
        writer.Write(Class);
        writer.Write(Advancement);
        writer.Write(Photo);
        writer.Write(Appearance);
        writer.Write(Level);
        writer.Write(Faction);
        writer.Write(AccountId);
        writer.Write(Permission);
        writer.Write(PvPKillCount);
        writer.Write(Weapon);
        writer.Write(SubWeapon);
        writer.Write(Costumes);
        writer.Write(ActiveBroachEffect);
        writer.Write(Title);
        writer.Write(League);
        writer.Write(Stats);
        writer.Write(Shop);
        writer.Write(Fp);
        writer.Write(Echelon);
        writer.Write(BattlePose);
        writer.Write(Status);
        writer.Write(Buffs);
        writer.Write(Slot);
        writer.Write(EqualizerId);
        writer.Write(_1);
        writer.Write(_2);
        writer.Write(_3);
    }

    #endregion IBinarySerializable
}
