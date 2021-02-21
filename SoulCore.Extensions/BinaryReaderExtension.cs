using SoulCore.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace SoulCore.Extensions
{
    public static class BinaryReaderExtension
    {
        #region Enumerable

        public static IEnumerable<uint> ReadUInt32Enumerable(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadUInt32());

        public static IEnumerable<int> ReadInt32Enumerable(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadInt32());

        public static IEnumerable<ushort> ReadUInt16Enumerable(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadUInt16());

        public static IEnumerable<byte> ReadByteEnumerable(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadByte());

        public static IEnumerable<string> ReadByteLengthUnicodeStringEnumerable(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadCharacterLengthUnicodeString());

        #endregion Enumerable

        #region Arrays

        public static uint[] ReadUInt32Array(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadUInt32()).ToArray();

        public static int[] ReadInt32Array(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadInt32()).ToArray();

        public static ushort[] ReadUInt16Array(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadUInt16()).ToArray();

        public static float[] ReadSingleArray(this BinaryReader br, byte count) =>
            Enumerable.Repeat(0, count).Select(_ => br.ReadSingle()).ToArray();

        #endregion Arrays

        #region Enums

        public static Class ReadClass(this BinaryReader br) =>
            (Class)br.ReadByte();

        public static ChatType ReadChatType(this BinaryReader br) =>
            (ChatType)br.ReadByte();

        public static DistrictLogOutWay ReadLogoutWayType(this BinaryReader br) =>
            (DistrictLogOutWay)br.ReadByte();

        public static StorageType ReadStorageType(this BinaryReader br) =>
            (StorageType)br.ReadByte();

        public static ClassAdvancement ReadClassAdvancement(this BinaryReader br) =>
            (ClassAdvancement)br.ReadByte();

        public static GroupRole ReadGroupRoleType(this BinaryReader br) =>
            (GroupRole)br.ReadByte();

        public static EnterGateWay ReadEnterGateWayType(this BinaryReader br) =>
            (EnterGateWay)br.ReadByte();

        public static ItemClassifySlotType ReadItemClassifySlotType(this BinaryReader br) =>
            (ItemClassifySlotType)br.ReadByte();

        public static ItemClassifyInventoryType ReadItemClassifyInventoryType(this BinaryReader br) =>
            (ItemClassifyInventoryType)br.ReadByte();

        #endregion Enums

        public static string ReadByteLengthUnicodeString(this BinaryReader br) =>
            Encoding.Unicode.GetString(br.ReadBytes(br.ReadUInt16()));

        public static string ReadCharacterLengthUnicodeString(this BinaryReader br) =>
            Encoding.Unicode.GetString(br.ReadBytes(br.ReadUInt16() * 2));

        public static string ReadByteLengthUtf8String(this BinaryReader br) =>
            Encoding.UTF8.GetString(br.ReadBytes(br.ReadUInt16()));

        public static Vector3 ReadVector3(this BinaryReader br) =>
            new(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());

        public static Vector2 ReadVector2(this BinaryReader br) =>
            new(br.ReadSingle(), br.ReadSingle());
    }
}