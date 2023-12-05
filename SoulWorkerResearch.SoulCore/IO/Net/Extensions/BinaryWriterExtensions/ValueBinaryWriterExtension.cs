using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.IO.Net.Packet;
using System.Numerics;
using SoulWorkerResearch.SoulCore.IO.Net.DataTypes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;

public static class ValueBinaryWriterExtension
{
    //public static void Write(this BinaryWriter @this, CharacterExShared value)
    //{
    //    @this.Write(value.Character);
    //    @this.Write(value.Position);
    //    @this.Write(value.SuperArmorGage);
    //}

    //public static void Write(this BinaryWriter @this, PositionInfoPacketSharedStructure value)
    //{
    //    @this.Write(value.LocationId);
    //    @this.Write(value.MapId);
    //    @this.Write(value.Position);
    //    @this.Write(value.Rotation);
    //}

    //public static void Write(this BinaryWriter @this, SuperArmorGageShared value)
    //{
    //    @this.Write(value.Current);
    //    @this.Write(value.Max);
    //}

    public static void Write(this BinaryWriter @this, PositionValue value)
    {
        @this.Write(value.Character);
        @this.Write(value.Map);
        @this.Write(value.Position);
        @this.Write(value.Yaw);
        @this.Write(value.TargetPosition);
    }
    
    public static void Write(this BinaryWriter @this, GestureLocationValue value)
    {
        @this.Write(value.Position);
        @this.Write(value.Rotation);
    }

    public static void Write(this BinaryWriter @this, PartyDataValue value)
    {
        @this.Write(value.Id);
        @this.Write(value.GroupType);
    }

    public static void Write(this BinaryWriter @this, EnterMapValue value)
    {
        @this.Write(value.ChangeType);
        @this.Write(value.ChangeServer);
        @this.Write(value.Result);
        @this.Write(value.PartyInfo);
    }

    public static void Write(this BinaryWriter @this, MapValue value)
    {
        @this.Write(value.Account);
        @this.Write(value.Person);
        @this.Write(value.Server);
        @this.Write(value.Jump);
        @this.Write(value.Portal);
        @this.Write(value.Map);
        @this.Write(value.ParentMap);
        @this.Write(value.EndPoint);
        @this.Write(value.Location);
        @this.Write(value.Direction);
    }

    public static void Write(this BinaryWriter @this, SerialEntity value) => @this.Write(value.Value);

    public static void Write(this BinaryWriter @this, LocationValue value)
    {
        @this.Write(value.World);
        @this.Write(value.Map);
        @this.Write(value.Position);
        @this.Write(value.Rotation);
    }

    public static void Write(this BinaryWriter @this, Vector3 value)
    {
        @this.Write(value.X);
        @this.Write(value.Y);
        @this.Write(value.Z);
    }

    public static void Write(this BinaryWriter @this, Vector2 value)
    {
        @this.Write(value.X);
        @this.Write(value.Y);
    }

    public static void Write(this BinaryWriter @this, CharacterValue value)
    {
        @this.Write(value.Id);
        @this.WriteUTF16UnicodeString(value.Name);
        @this.Write(value.Class);
        @this.Write(value.Advancement);
        @this.Write(value.Photo);
        @this.Write(value.Appearance);
        @this.Write(value.Level);
        @this.Write(value.Faction);
        @this.Write(value.AccountId);
        @this.Write(value.Permission);
        @this.Write(value.PvPKillCount);
        @this.Write(value.Weapon);
        @this.Write(value.SubWeapon);
        @this.Write(value.Costumes);
        @this.Write(value.ActiveBroachEffect);
        @this.Write(value.Title);
        @this.Write(value.League);
        @this.Write(value.Stats);
        @this.Write(value.Shop);
        @this.Write(value.Fp);
        @this.Write(value.Echelon);
        @this.Write(value.BattlePose);
        @this.Write(value.Stats);
        @this.Write(value.Buffs);
        @this.Write(value.Slot);
        @this.Write(value.EqualizerId);
        @this.Write(value._1);
        @this.Write(value._2);
        @this.Write(value._3);
    }

    public static void Write(this BinaryWriter @this, HairEntity value)
    {
        @this.Write(value.Style);
        @this.Write(value.Color);
    }

    public static void Write(this BinaryWriter @this, AppearanceValue.EntityValue value)
    {
        @this.Write(value.Hair);
        @this.Write(value.EyeColor);
        @this.Write(value.SkinColor);
    }

    public static void Write(this BinaryWriter @this, AppearanceValue value)
    {
        @this.Write(value.Face);
        @this.Write(value.Shape);
        @this.Write(value.Look);
    }

    public static void Write(this BinaryWriter @this, GearValue value)
    {
        @this.Write(value.UpgradeLevel);
        @this.Write(value.PrototypeId);
    }

    public static void Write(this BinaryWriter @this, CostumeValues value)
    {
        foreach (var (view, battle) in value.Look.Zip(value.Shape, Tuple.Create))
        {
            @this.Write(battle.Serial);
            @this.Write(battle.PrototypeId);
            @this.Write(battle.Color);

            @this.Write(view.Serial);
            @this.Write(view.PrototypeId);
            @this.Write(view.Color);
        }
    }

    public static void Write(this BinaryWriter @this, TitleEntity value)
    {
        @this.Write(value.Prefix);
        @this.Write(value.Suffix);
    }

    public static void Write(this BinaryWriter @this, LeagueValue value)
    {
        @this.Write(value.Id);
        @this.WriteUTF16UnicodeString(value.Name);
        @this.Write(value.Card);
    }

    public static void Write(this BinaryWriter @this, CardInfoEntity value)
    {
        @this.Write(value.Primary);
        @this.Write(value.Secondary);
    }

    public static void Write(this BinaryWriter @this, StatValues value)
    {
        @this.Write(value.Health);
        @this.Write(value.SoulGain);
        @this.Write(value.SoulVapor);
        @this.Write(value.Stamina);
        @this.Write(value.Fd);
        @this.Write(value.AttackSpeed);
        @this.Write(value.MoveSpeed);
    }

    public static void Write(this BinaryWriter @this, StatEntity value)
    {
        @this.Write(value.Current);
        @this.Write(value.Max);
    }

    public static void Write(this BinaryWriter @this, PrivateShopValue value)
    {
        @this.Write(value.Type);
        @this.WriteUTF16UnicodeString(value.Title);
    }

    public static void Write(this BinaryWriter @this, FatiguePointValue value)
    {
        @this.Write(value.Value);
        @this.Write(value.Extended);
        @this.Write(value.Cafe);
    }

    public static void Write(this BinaryWriter @this, EchelonValue value)
    {
        @this.Write(value.Level);
        @this.Write(value.Exp);
    }

    public static void Write(this BinaryWriter @this, BuffValue value)
    {
        @this.Write(value.Id);
        @this.Write(value.Time);
        @this.Write(value.Count);
        @this.Write(value.OwnerId);
        @this.Write(value.Show);
    }

    public static void Write(this BinaryWriter @this, MapEntity value) => @this.Write(value.Value);

    public static void Write(this BinaryWriter @this, Opcode value) => @this.Write(value.Value);

    public static void Write(this BinaryWriter @this, PacketHeader value)
    {
        @this.Write(value.Magic);
        @this.Write(value.Size);
        @this.Write(value.Protocol);
        // @this.Write(value.Key);
    }
}
