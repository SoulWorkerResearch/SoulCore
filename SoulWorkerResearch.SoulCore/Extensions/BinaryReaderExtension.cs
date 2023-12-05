using System.Drawing;
using System.Numerics;
using System.Text;
using SoulWorkerResearch.SoulCore.Defines;

namespace SoulWorkerResearch.SoulCore.Extensions;

public static class BinaryReaderExtension
{
    #region Enumerable

    public static IEnumerable<uint> ReadUInt32AsEnumerable(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => reader.ReadUInt32());
    }

    public static IEnumerable<int> ReadInt32AsEnumerable(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => reader.ReadInt32());
    }

    public static IEnumerable<ushort> ReadUInt16AsEnumerable(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => reader.ReadUInt16());
    }

    public static IEnumerable<byte> ReadByteAsEnumerable(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => reader.ReadByte());
    }

    public static IEnumerable<BoosterMazeEffectType> ReadBoosterEffectTypeAsEnumerable(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => (BoosterMazeEffectType)reader.ReadByte());
    }

    public static IEnumerable<string> ReadByteLengthUnicodeStringAsEnumerable(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => reader.ReadUTF16UnicodeString());
    }

    #endregion Enumerable

    #region Arrays

    public static uint[] ReadUInt32AsArray(this BinaryReader reader, int count)
    {
        return reader.ReadUInt32AsEnumerable(count).ToArray();
    }

    public static int[] ReadInt32AsArray(this BinaryReader reader, int count)
    {
        return reader.ReadInt32AsEnumerable(count).ToArray();
    }

    public static ushort[] ReadUInt16AsArray(this BinaryReader reader, int count)
    {
        return reader.ReadUInt16AsEnumerable(count).ToArray();
    }

    public static byte[] ReadByteAsArray(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => reader.ReadByte()).ToArray();
    }

    public static float[] ReadSingleAsArray(this BinaryReader reader, int count)
    {
        return Enumerable.Repeat(0, count).Select(_ => reader.ReadSingle()).ToArray();
    }

    public static string[] ReadByteLengthUnicodeStringAsArray(this BinaryReader reader, int count)
    {
        return reader.ReadByteLengthUnicodeStringAsEnumerable(count).ToArray();
    }

    #endregion Arrays

    #region Enums

    public static BoosterDecreaseTime ReadBoosterDecreaseTime(this BinaryReader reader)
    {
        return (BoosterDecreaseTime)reader.ReadByte();
    }

    public static Character ReadClass(this BinaryReader reader)
    {
        return (Character)reader.ReadByte();
    }

    public static ChatType ReadChatType(this BinaryReader reader)
    {
        return (ChatType)reader.ReadByte();
    }

    public static LogOutType ReadLogoutWayType(this BinaryReader reader)
    {
        return (LogOutType)reader.ReadByte();
    }

    public static StorageType ReadStorageType(this BinaryReader reader)
    {
        return (StorageType)reader.ReadByte();
    }

    public static Advancement ReadClassAdvancement(this BinaryReader reader)
    {
        return (Advancement)reader.ReadByte();
    }

    public static Permisson ReadPermission(this BinaryReader reader)
    {
        return (Permisson)reader.ReadByte();
    }

    public static GroupRole ReadGroupRoleType(this BinaryReader reader)
    {
        return (GroupRole)reader.ReadByte();
    }

    public static EnterGateWay ReadEnterGateWayType(this BinaryReader reader)
    {
        return (EnterGateWay)reader.ReadByte();
    }

    public static ItemClassifySlotType ReadItemClassifySlotType(this BinaryReader reader)
    {
        return (ItemClassifySlotType)reader.ReadByte();
    }

    public static ItemClassifyInventoryType ReadItemClassifyInventoryType(this BinaryReader reader)
    {
        return (ItemClassifyInventoryType)reader.ReadByte();
    }

    public static AuthType ReadAuthType(this BinaryReader reader)
    {
        return (AuthType)reader.ReadByte();
    }

    #endregion Enums

    #region Strings

    public static string ReadUTF8UnicodeString(this BinaryReader reader)
    {
        return Encoding.Unicode.GetString(reader.ReadBytes(reader.ReadUInt16()));
    }

    public static string ReadUTF16UnicodeString(this BinaryReader reader)
    {
        return Encoding.Unicode.GetString(reader.ReadBytes(reader.ReadUInt16() * 2));
    }

    public static string ReadVisionByteLengthUtf8String(this BinaryReader reader)
    {
        return Encoding.UTF8.GetString(reader.ReadBytes(reader.ReadInt32()));
    }

    #endregion Strings

    #region Structs

    public static Vector3 ReadVector3(this BinaryReader reader)
    {
        return new(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
    }

    public static Vector2 ReadVector2(this BinaryReader reader)
    {
        return new(reader.ReadSingle(), reader.ReadSingle());
    }

    public static Color ReadColor(this BinaryReader reader)
    {
        return Color.FromArgb(red: reader.ReadByte(), green: reader.ReadByte(), blue: reader.ReadByte(), alpha: reader.ReadByte());
    }

    #endregion Structs
}
