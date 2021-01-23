﻿using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses;
using SoulCore.IO.Network.Responses.Shared;
using SoulCore.Types;
using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace SoulCore.IO.Network
{
    public sealed class PacketWriter : BinaryWriter
    {
        internal void WriteOptionStatus(UserOptionStatus value) => Write((ushort)value);

        internal void WriteGateEnterResult(GateEnterResult value) => Write((byte)value);

        internal void WriteClassAdvancement(ClassAdvancement value) => Write((byte)value);

        internal void WriteChannelLoadStatus(ChannelLoadStatus value) => Write((byte)value);

        internal void WriteCharacterStat(CharacterStat value) => Write((ushort)value);

        internal void WriteDistrictLogOutStatus(DistrictLogOutStatus value) => Write((byte)value);

        internal void WriteDistrictLogOutWay(DistrictLogOutWay value) => Write((byte)value);

        internal void WriteCharacterInfoResult(CharacterInfoResult value) => Write((byte)value);

        internal void WriteCharacter(CharacterShared character)
        {
            WriteCharacterMain(character);
            WriteCharacterWeapon(character);
            WriteCharacterFashion(character);
            WriteCharacterMeta(character);
        }

        private void WriteCharacterMain(CharacterShared value)
        {
            Write(value.Id);
            WriteByteLengthUnicodeString(value.Name);
            WriteClass(value.Class);
            WriteClassAdvancement(value.Advancement);
            Write(value.Photo);
            Write(value.Appearance);
            Write(value.Level);
            Write(new byte[10]);
        }

        private void WriteCharacterWeapon(CharacterShared value)
        {
            Write(value.WeaponItem.UpgradeLevel);
            Write(value.WeaponItem.PrototypeId);
            Write(byte.MinValue);
            Write(-1);
        }

        private void WriteCharacterFashion(CharacterShared value)
        {
            static void WriteFashionEntry(PacketWriter writer, int prototypeId = -1, uint color = uint.MinValue)
            {
                writer.Write(-1);
                writer.Write(-1);
                writer.Write(prototypeId);
                writer.Write(color);

                writer.Write(-1);
                writer.Write(-1);
                writer.Write(-1);
                writer.Write(uint.MinValue);
            }

            foreach ((CharacterShared.EquippedCostumeInfos.CostumeInfo? view, CharacterShared.EquippedCostumeInfos.CostumeInfo? battle) in value.EquippedItems.View.Zip(value.EquippedItems.Battle, Tuple.Create))
            {
                if (view is not null)
                {
                    WriteFashionEntry(this, view.PrototypeId, view.Color);
                    continue;
                }

                if (battle is not null)
                {
                    WriteFashionEntry(this, battle.PrototypeId, battle.Color);
                    continue;
                }

                WriteFashionEntry(this);
            }
        }

        private void WriteCharacterMeta(CharacterShared value)
        {
            const ushort primaryEnergy = 0;
            const ushort extraEnergy = 0;
            const uint titlePrimary = 0;
            const uint titleSecondary = 0;
            const uint guildId = 0;
            const string guildName = "";

            Write(uint.MinValue); // Unknown3
            Write(titlePrimary);
            Write(titleSecondary);
            Write(guildId);
            WriteByteLengthUnicodeString(guildName);
            Write(uint.MinValue); // 1 Unknown4
            Write(value.Stats.CurrentHp); // 2
            Write(value.Stats.MaxHp); // 3
            Write(value.Stats.CurrentSg); // 4
            Write(value.Stats.MaxSg); // 5
            Write(uint.MinValue); // 6
            Write(uint.MinValue); // 7
            Write(uint.MinValue); // 8 Stamina???
            Write(value.Stats.MaxStamina); // 9 Max Stamina
            Write(uint.MinValue); // 10
            Write(uint.MinValue); // 11
            Write(value.Stats.MoveSpeed);
            Write(value.Stats.AttackSpeed);
            Write(ushort.MinValue);
            Write(byte.MinValue);
            Write(primaryEnergy);
            Write(extraEnergy);
            Write(byte.MinValue);
            Write(byte.MinValue); // 00
            Write(byte.MinValue); // 08
            Write(uint.MinValue); // 95 36 68 3B
            Write(ushort.MinValue); // 00 00
            Write(uint.MinValue); // 00 00 00 00
            Write(uint.MinValue); // 00 00 00 00
            Write(value.Slot);
            Write(uint.MinValue); // 00 00 00 00
            Write((byte)1); // 00
            Write(uint.MinValue); // 00 00 00 00
        }

        private void Write(CharacterShared.AppearanceInfo.HairInfo value)
        {
            Write(value.Style);
            Write(value.Color);
        }

        private void Write(CharacterShared.AppearanceInfo value)
        {
            Write(ushort.MinValue);
            Write(ushort.MinValue);
            Write(value.Hair);
            Write(value.EyeColor);
            Write(value.SkinColor);
            Write(value.EquippedHair);
            Write(value.EquippedEyeColor);
            Write(value.EquippedSkinColor);
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

        internal void Write(SPosInfoSharedResponse value)
        {
            Write(value.LocationId);
            Write(value.Map);
            Write(value.Pos);
            Write(value.Rot);
        }

        internal void WritePlace(PlaceShared value)
        {
            Write(value.Location);
            Write((ulong)0);
            Write(value.Position);
            Write(value.Rotation);
            Write(value.SuperArmourGage.Current);
            Write(value.SuperArmourGage.Max);
        }

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

        internal void WriteDistrictConnectResult(DistrictConnectResult value) =>
            Write((byte)value);

        internal void WriteByteLengthUnicodeString(string str)
        {
            Write((ushort)(str.Length * 2));
            Write(Encoding.Unicode.GetBytes(str));
        }

        internal void WriteNpcVisability(NpcVisablity value) =>
            Write((byte)value);

        internal void WriteAuthLoginErrorMessageCode(AuthLoginErrorMessageCode value) => Write((int)value);

        internal void WriteSpecialOption(SpecialOption value) => Write((byte)value);

        internal void WriteChatType(ChatType value) => Write((uint)value);

        internal void WriteClass(Class value) => Write((byte)value);

        internal void WriteGateStatus(GateStatus value) => Write((uint)value);

        internal void WriteProfileStatus(ProfileStatus value) => Write((byte)value);

        public PacketWriter(CategoryCommand category, object command) : base(new MemoryStream(ushort.MaxValue), Encoding.ASCII, false)
        {
            /// Write SoulWorker magic bytes
            Write((byte)0x03);
            Write((byte)0x00);

            /// Write packet size (just reserve space, overwritten in GetBuffer)
            Write(ushort.MaxValue);

            /// I dont know
            Write((byte)0x1);

            Write((byte)category);
            Write((byte)command);
        }

        public byte[] GetBuffer()
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