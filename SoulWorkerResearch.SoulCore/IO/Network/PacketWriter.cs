using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.IO.Network.PacketSharedStructure;
using SoulWorkerResearch.SoulCore.IO.Network.Responses;
using SoulWorkerResearch.SoulCore.IO.Network.Responses.Shared;
using SoulWorkerResearch.SoulCore.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    public sealed class PacketWriter : BinaryWriter
    {
        internal void WriteOptionStatus(UserOptionStatus value) => Write((ushort)value);

        internal void WriteGateEnterResult(GateEnterResult value) => Write((byte)value);

        internal void WriteClassAdvancement(ClassAdvancement value) => Write((byte)value);

        internal void WriteChannelLoadStatus(ChannelLoadStatus value) => Write((byte)value);

        internal void WriteCharacterStat(StatType value) => Write((ushort)value);

        internal void WriteDistrictLogOutStatus(DistrictLogOutStatus value) => Write((byte)value);

        internal void WriteDistrictLogOutWay(DistrictLogOutWay value) => Write((byte)value);

        internal void WriteCharacterInfoResult(CharacterInfoResult value) => Write((byte)value);

        internal void WriteSyncUserFlags(SyncUserFlags value) => Write((int)value);

        internal void WriteUserFlags(UserFlags value) => Write((int)value);

        internal void Write(CharacterExPacketSharedStructure value)
        {
            Write(value.Character);
            Write(value.Position);
            Write(value.SuperArmorGage);
        }

        internal void Write(PositionInfoPacketSharedStructure value)
        {
            Write(value.LocationId);
            Write(value.MapId);
            Write(value.Position);
            Write(value.Rotation);
        }

        private void Write(SuperArmorGagePacketSharedStructure value)
        {
            Write(value.Current);
            Write(value.Max);
        }

        internal void Write(CharacterPacketSharedStructure value)
        {
            Write(value.Id);
            WriteByteLengthUnicodeString(value.Name);
            WriteClass(value.Class);
            WriteClassAdvancement(value.Advancement);
            Write(value.Photo);
            Write(value.Appearance);
            Write(value.Level);
            Write(value.Faction);
            Write(value.AccountId);
            Write(value.GameMasterPower);
            Write(value.PvPKillCount);
            Write(value.WeaponItem);
            Write(value.SubWeaponItem);
            Write(value.CostumesItems);
            Write(value.ActiveBroachEffect);
            Write(value.Title);
            Write(value.League);
            Write(value.Stats);
            Write(value.Shop);
            Write(value.Fp);
            Write(value.Echelon);
            Write(value.BattlePose);
            Write(value.Stats);
            Write(value.Buffs);
            Write(value.Slot);
            Write(value.EqualizerId);
            Write(value._1);
            Write(value._2);
            Write(value._3);
        }

        private void Write(CharacterPacketSharedStructure.AppearanceInfo.HairInfo value)
        {
            Write(value.Style);
            Write(value.Color);
        }

        private void Write(CharacterPacketSharedStructure.AppearanceInfo value)
        {
            Write(value._1);
            Write(value.Hair);
            Write(value.EyeColor);
            Write(value.SkinColor);
            Write(value.EquippedHair);
            Write(value.EquippedEyeColor);
            Write(value.EquippedSkinColor);
        }

        private void Write(CharacterPacketSharedStructure.GearInfo value)
        {
            Write(value.UpgradeLevel);
            Write(value.PrototypeId);
        }

        private void Write(CharacterPacketSharedStructure.CostumeInfos value)
        {
            foreach ((CharacterPacketSharedStructure.CostumeInfos.CostumeInfo view, CharacterPacketSharedStructure.CostumeInfos.CostumeInfo battle) in value.View.Zip(value.Battle, Tuple.Create))
            {
                Write(battle.Serial);
                Write(battle.PrototypeId);
                Write(battle.Color);

                Write(view.Serial);
                Write(view.PrototypeId);
                Write(view.Color);
            }
        }

        private void Write(CharacterPacketSharedStructure.TitleInfo value)
        {
            Write(value.Prefix);
            Write(value.Suffix);
        }

        private void Write(CharacterPacketSharedStructure.LeagueInfo value)
        {
            Write(value.Id);
            WriteByteLengthUnicodeString(value.Name);
            Write(value.Card);
        }

        private void Write(CharacterPacketSharedStructure.LeagueInfo.CardInfo value)
        {
            Write(value.Design);
            Write(value.BackDesign);
        }

        private void Write(CharacterPacketSharedStructure.StatsInfo value)
        {
            Write(value.Hp);
            Write(value.Sg);
            Write(value.Sv);
            Write(value.St);
            Write(value.Fd);
            Write(value.AttackSpeed);
            Write(value.MoveSpeed);
        }

        private void Write(CharacterPacketSharedStructure.StatsInfo.StatInfo value)
        {
            Write(value.Current);
            Write(value.Max);
        }

        private void Write(CharacterPacketSharedStructure.PrivateShopInfo value)
        {
            Write(value.Type);
            WriteByteLengthUnicodeString(value.Title);
        }

        private void Write(CharacterPacketSharedStructure.FpInfo value)
        {
            Write(value.Fp);
            Write(value.BonusFp);
            Write(value.PcBangFp);
        }

        private void Write(CharacterPacketSharedStructure.EchelonInfo value)
        {
            Write(value.Level);
            Write(value.Exp);
        }

        private void Write(CharacterPacketSharedStructure.BuffInfo value)
        {
            Write(value.Id);
            Write(value.Time);
            Write(value.Count);
            Write(value.OwnerId);
            Write(value.Show);
        }

        private void Write(IEnumerable<CharacterPacketSharedStructure.BuffInfo> values)
        {
            Write((byte)values.Count());
            foreach (CharacterPacketSharedStructure.BuffInfo value in values)
            {
                Write(value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void Write(Vector3 value)
        {
            Write(value.X);
            Write(value.Y);
            Write(value.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void Write(Vector2 value)
        {
            Write(value.X);
            Write(value.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void Write(MapIdPacketSharedStructure value) => Write(value.Seq);

        internal void WriteNumberLengthUtf8String(string str)
        {
            Write((ushort)str.Length);
            Write(Encoding.UTF8.GetBytes(str));
        }

        internal void WriteByteLengthUtf8String(string str)
        {
            Write((ushort)(str.Length * 2));
            Write(Encoding.UTF8.GetBytes(str));
        }

        internal void WriteNumberLengthChars(char[] str)
        {
            Write((ushort)str.Length);
            Write(str);
        }

        internal void WriteNumberLengthUnicodeString(string str)
        {
            Write((ushort)str.Length);
            Write(Encoding.Unicode.GetBytes(str));
        }

        internal void WriteDistrictConnectResult(DistrictConnectResult value) => Write((byte)value);

        internal void WriteByteLengthUnicodeString(string str)
        {
            Write((ushort)(str.Length * 2));
            Write(Encoding.Unicode.GetBytes(str));
        }

        internal void WriteNpcVisability(NpcVisablity value) => Write((byte)value);

        internal void WriteAuthLoginErrorMessageCode(AuthLoginErrorMessageCode value) => Write((int)value);

        internal void WriteSpecialOption(SpecialOption value) => Write((byte)value);

        internal void WriteChatType(ChatType value) => Write((uint)value);

        internal void WriteClass(Class value) => Write((byte)value);

        internal void WriteGateStatus(GateStatus value) => Write((uint)value);

        internal void WriteProfileStatus(ProfileStatus value) => Write((byte)value);

        public PacketWriter(CategoryCommand category, object command) :
            base(new MemoryStream(ushort.MaxValue), Encoding.ASCII, false)
        {
            /// Write SoulWorker magic bytes
            Write(CommonDefines.PacketHeaderMagic1);
            Write(CommonDefines.PacketHeaderMagic2);

            /// Write packet size (just reserve space, overwritten in GetBuffer)
            Write(ushort.MaxValue);

            /// I dont know
            Write((byte)0x1);

            Write((byte)category);
            Write((byte)command);
        }

        internal byte[] GetBuffer()
        {
            /// Skip SoulWorker magic bytes
            Seek(sizeof(ushort), SeekOrigin.Begin);

            /// Write actual packet size
            Write((ushort)BaseStream.Length);

            /// Get and return RAW buffer
            return ((MemoryStream)BaseStream).GetBuffer();
        }
    }
}

// https://youtu.be/9MKouooyOnY
