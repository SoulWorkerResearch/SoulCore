using SoulWorkerResearch.SoulCore.Defines;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace SoulWorkerResearch.SoulCore.Extensions;

public static class BinaryReaderExtension
{
    #region Enumerable

    public static IEnumerable<uint> ReadUInt32AsEnumerable(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => reader.ReadUInt32());

    public static IEnumerable<int> ReadInt32AsEnumerable(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => reader.ReadInt32());

    public static IEnumerable<ushort> ReadUInt16AsEnumerable(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => reader.ReadUInt16());

    public static IEnumerable<byte> ReadByteAsEnumerable(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => reader.ReadByte());

    public static IEnumerable<BoosterEffectType> ReadBoosterEffectTypeAsEnumerable(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => (BoosterEffectType)reader.ReadByte());

    public static IEnumerable<string> ReadByteLengthUnicodeStringAsEnumerable(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => reader.ReadUTF16UnicodeString());

    #endregion Enumerable

    #region Arrays

    public static uint[] ReadUInt32AsArray(this BinaryReader reader, int count) =>
        reader.ReadUInt32AsEnumerable(count).ToArray();

    public static int[] ReadInt32AsArray(this BinaryReader reader, int count) =>
        reader.ReadInt32AsEnumerable(count).ToArray();

    public static ushort[] ReadUInt16AsArray(this BinaryReader reader, int count) =>
        reader.ReadUInt16AsEnumerable(count).ToArray();

    public static byte[] ReadByteAsArray(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => reader.ReadByte()).ToArray();

    public static float[] ReadSingleAsArray(this BinaryReader reader, int count) =>
        Enumerable.Repeat(0, count).Select(_ => reader.ReadSingle()).ToArray();

    public static string[] ReadByteLengthUnicodeStringAsArray(this BinaryReader reader, int count) =>
        reader.ReadByteLengthUnicodeStringAsEnumerable(count).ToArray();

    #endregion Arrays

    #region Enums

    public static BoosterDecreaseTime ReadBoosterDecreaseTime(this BinaryReader reader) =>
        (BoosterDecreaseTime)reader.ReadByte();

    public static Class ReadClass(this BinaryReader reader) =>
        (Class)reader.ReadByte();

    public static ChatType ReadChatType(this BinaryReader reader) =>
        (ChatType)reader.ReadByte();

    public static DistrictLogOutWay ReadLogoutWayType(this BinaryReader reader) =>
        (DistrictLogOutWay)reader.ReadByte();

    public static StorageType ReadStorageType(this BinaryReader reader) =>
        (StorageType)reader.ReadByte();

    public static ClassAdvancement ReadClassAdvancement(this BinaryReader reader) =>
        (ClassAdvancement)reader.ReadByte();

    public static Permisson ReadPermission(this BinaryReader reader) =>
        (Permisson)reader.ReadByte();

    public static GroupRole ReadGroupRoleType(this BinaryReader reader) =>
        (GroupRole)reader.ReadByte();

    public static EnterGateWay ReadEnterGateWayType(this BinaryReader reader) =>
        (EnterGateWay)reader.ReadByte();

    public static ItemClassifySlotType ReadItemClassifySlotType(this BinaryReader reader) =>
        (ItemClassifySlotType)reader.ReadByte();

    public static ItemClassifyInventoryType ReadItemClassifyInventoryType(this BinaryReader reader) =>
        (ItemClassifyInventoryType)reader.ReadByte();

    public static AuthType ReadAuthType(this BinaryReader reader) =>
        (AuthType)reader.ReadByte();

    #endregion Enums

    #region Strings

    public static string ReadUTF8UnicodeString(this BinaryReader reader) =>
        Encoding.Unicode.GetString(reader.ReadBytes(reader.ReadUInt16()));

    public static string ReadUTF16UnicodeString(this BinaryReader reader) =>
        Encoding.Unicode.GetString(reader.ReadBytes(reader.ReadUInt16() * 2));

    public static string ReadVisionByteLengthUtf8String(this BinaryReader reader) =>
        Encoding.UTF8.GetString(reader.ReadBytes(reader.ReadInt32()));

    #endregion Strings

    #region Structs

    public static Vector3 ReadVector3(this BinaryReader reader) =>
        new(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());

    public static Vector2 ReadVector2(this BinaryReader reader) =>
        new(reader.ReadSingle(), reader.ReadSingle());

    public static Color ReadColor(this BinaryReader reader) =>
        Color.FromArgb(red: reader.ReadByte(), green: reader.ReadByte(), blue: reader.ReadByte(), alpha: reader.ReadByte());

    #endregion Structs
}
