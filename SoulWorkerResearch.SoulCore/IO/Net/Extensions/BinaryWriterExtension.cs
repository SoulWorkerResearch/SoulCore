using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Packet;
using System.Net;
using System.Text;

namespace SoulWorkerResearch.SoulCore.IO.Net.Extensions;

public static class BinaryWriterExtension
{
    #region Strings

    public static void WriteUTF8UnicodeString(this BinaryWriter writer, string value)
    {
        writer.Write((ushort)value.Length);
        writer.Write(Encoding.Unicode.GetBytes(value));
    }

    public static void WriteUTF16UnicodeString(this BinaryWriter writer, string value)
    {
        writer.Write((ushort)(value.Length * 2));
        writer.Write(Encoding.Unicode.GetBytes(value));
    }

    public static void WriteVisionByteLengthUtf8String(this BinaryWriter writer, string value)
    {
        writer.Write(value.Length);
        writer.Write(Encoding.UTF8.GetBytes(value));
    }

    #endregion Strings

    #region Enums

    public static void Write(this BinaryWriter writer, DistrictConnectResult value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, UserOptionStatus value) =>
        writer.Write((ushort)value);

    public static void Write(this BinaryWriter writer, GateEnterResult value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, ClassAdvancement value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, ChannelLoadStatus value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, StatType value) =>
        writer.Write((ushort)value);

    public static void Write(this BinaryWriter writer, DistrictLogOutStatus value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, DistrictLogOutWay value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, NpcVisablity value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, Permisson value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, AuthLoginErrorMessageCode value) =>
        writer.Write((int)value);

    public static void Write(this BinaryWriter writer, SpecialOption value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, ChatType value) =>
        writer.Write((uint)value);

    public static void Write(this BinaryWriter writer, Class value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, GateStatus value) =>
        writer.Write((uint)value);

    public static void Write(this BinaryWriter writer, ProfileStatus value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, PacketMagick value) =>
        writer.Write(value.Value);

    public static void Write(this BinaryWriter writer, PacketProtocol value) =>
        writer.Write((byte)value);

    public static void Write(this BinaryWriter writer, Opcode value) =>
        writer.Write(value.Value);

    public static void Write(this BinaryWriter writer, PacketHeader value)
    {
        writer.Write(value.Magick);
        writer.Write(value.Size);
        writer.Write(value.Protocol);
        writer.Write(value.Key);
    }

    #endregion Enums

    //internal void WriteCharacterInfoResult(CharacterInfoResult value) => writer.Write((byte)value);

    //internal void WriteSyncUserFlags(SyncUserFlags value) => writer.Write((int)value);

    //internal void WriteUserFlags(UserFlags value) => writer.Write((int)value);

    //public static void Write(this BinaryWriter writer, CharacterExShared value)
    //{
    //    writer.Write(value.Character);
    //    writer.Write(value.Position);
    //    writer.Write(value.SuperArmorGage);
    //}

    //public static void Write(this BinaryWriter writer, PositionInfoPacketSharedStructure value)
    //{
    //    writer.Write(value.LocationId);
    //    writer.Write(value.MapId);
    //    writer.Write(value.Position);
    //    writer.Write(value.Rotation);
    //}

    //public static void Write(this BinaryWriter writer, SuperArmorGageShared value)
    //{
    //    writer.Write(value.Current);
    //    writer.Write(value.Max);
    //}

    public static void Write(this BinaryWriter writer, SerialValue value) =>
        writer.Write(value.Value);

    public static void Write(this BinaryWriter writer, CharacterValue value)
    {
        writer.Write(value.Id);
        writer.WriteUTF16UnicodeString(value.Name);
        writer.Write(value.Class);
        writer.Write(value.Advancement);
        writer.Write(value.Photo);
        writer.Write(value.Appearance);
        writer.Write(value.Level);
        writer.Write(value.Faction);
        writer.Write(value.AccountId);
        writer.Write(value.Permission);
        writer.Write(value.PvPKillCount);
        writer.Write(value.Weapon);
        writer.Write(value.SubWeapon);
        writer.Write(value.Costumes);
        writer.Write(value.ActiveBroachEffect);
        writer.Write(value.Title);
        writer.Write(value.League);
        writer.Write(value.Stats);
        writer.Write(value.Shop);
        writer.Write(value.Fp);
        writer.Write(value.Echelon);
        writer.Write(value.BattlePose);
        writer.Write(value.Stats);
        writer.Write(value.Buffs);
        writer.Write(value.Slot);
        writer.Write(value.EqualizerId);
        writer.Write(value._1);
        writer.Write(value._2);
        writer.Write(value._3);
    }

    public static void Write(this BinaryWriter writer, HairValue value)
    {
        writer.Write(value.Style);
        writer.Write(value.Color);
    }

    public static void Write(this BinaryWriter writer, AppearanceEntryValue value)
    {
        writer.Write(value.Hair);
        writer.Write(value.EyeColor);
        writer.Write(value.SkinColor);
    }

    public static void Write(this BinaryWriter writer, AppearanceValue value)
    {
        writer.Write(value.Face);
        writer.Write(value.Shape);
        writer.Write(value.Look);
    }

    public static void Write(this BinaryWriter writer, GearValue value)
    {
        writer.Write(value.UpgradeLevel);
        writer.Write(value.PrototypeId);
    }

    public static void Write(this BinaryWriter writer, CostumeValues value)
    {
        foreach ((var view, var battle) in value.Look.Zip(value.Shape, Tuple.Create))
        {
            writer.Write(battle.Serial);
            writer.Write(battle.PrototypeId);
            writer.Write(battle.Color);

            writer.Write(view.Serial);
            writer.Write(view.PrototypeId);
            writer.Write(view.Color);
        }
    }

    public static void Write(this BinaryWriter writer, TitleValue value)
    {
        writer.Write(value.Prefix);
        writer.Write(value.Suffix);
    }

    public static void Write(this BinaryWriter writer, LeagueValue value)
    {
        writer.Write(value.Id);
        writer.WriteUTF16UnicodeString(value.Name);
        writer.Write(value.Card);
    }

    public static void Write(this BinaryWriter writer, CardInfo value)
    {
        writer.Write(value.Design);
        writer.Write(value.BackDesign);
    }

    public static void Write(this BinaryWriter writer, StatValues value)
    {
        writer.Write(value.Hp);
        writer.Write(value.Sg);
        writer.Write(value.Sv);
        writer.Write(value.St);
        writer.Write(value.Fd);
        writer.Write(value.As);
        writer.Write(value.Ms);
    }

    public static void Write(this BinaryWriter writer, StatValue value)
    {
        writer.Write(value.Current);
        writer.Write(value.Max);
    }

    public static void Write(this BinaryWriter writer, PrivateShopValue value)
    {
        writer.Write(value.Type);
        writer.WriteUTF16UnicodeString(value.Title);
    }

    public static void Write(this BinaryWriter writer, FpValue value)
    {
        writer.Write(value.Fp);
        writer.Write(value.BonusFp);
        writer.Write(value.PcBangFp);
    }

    public static void Write(this BinaryWriter writer, EchelonValue value)
    {
        writer.Write(value.Level);
        writer.Write(value.Exp);
    }

    public static void Write(this BinaryWriter writer, BuffValue value)
    {
        writer.Write(value.Id);
        writer.Write(value.Time);
        writer.Write(value.Count);
        writer.Write(value.OwnerId);
        writer.Write(value.Show);
    }

    public static void Write(this BinaryWriter writer, IEnumerable<BuffValue> values)
    {
        writer.Write((byte)values.Count());
        foreach (BuffValue value in values)
        {
            writer.Write(value);
        }
    }

    public static void Write(this BinaryWriter writer, IEnumerable<byte> values)
    {
        foreach (var value in values)
        {
            writer.Write(value);
        }
    }

    public static void Write(this BinaryWriter writer, IEnumerable<bool> values)
    {
        foreach (var value in values)
        {
            writer.Write(value);
        }
    }

    public static void Write(this BinaryWriter writer, DnsEndPoint value)
    {
        writer.WriteUTF8UnicodeString(value.Host);
        writer.Write(value.Port);
    }
}
