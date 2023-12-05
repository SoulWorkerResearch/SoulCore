using System.Net;
using System.Text;

namespace SoulWorkerResearch.SoulCore.IO.Net.Extensions;

public static class BinaryWriterExtension
{
    public static void Write(this BinaryWriter writer, IPAddress value) => writer
        .WriteUTF8UnicodeString(value.ToString());

    public static void Write(this BinaryWriter writer, IPEndPoint value)
    {
        writer.Write(value.Address);
        writer.Write(value.Port);
    }

    public static void Write(this BinaryWriter writer, DnsEndPoint value)
    {
        writer.WriteUTF8UnicodeString(value.Host);
        writer.Write(value.Port);
    }

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
}
