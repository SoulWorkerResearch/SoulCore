using SoulWorkerResearch.SoulCore.DataTypes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;

public static class EnumerableBinaryWriterExtension
{
    public static void Write(this BinaryWriter writer, IEnumerable<BuffValue> values)
    {
        writer.Write((byte)values.Count());
        foreach (var value in values)
        {
            writer.Write(value);
        }
    }

    public static void Write(this BinaryWriter writer, IEnumerable<int> values)
    {
        foreach (var value in values)
        {
            writer.Write(value);
        }
    }

    public static void Write(this BinaryWriter writer, IEnumerable<uint> values)
    {
        foreach (var value in values)
        {
            writer.Write(value);
        }
    }

    public static void Write(this BinaryWriter writer, IEnumerable<byte> values) => writer
        .Write(values.ToArray());

    public static void Write(this BinaryWriter writer, IEnumerable<bool> values)
    {
        foreach (var value in values)
        {
            writer.Write(value);
        }
    }
}
