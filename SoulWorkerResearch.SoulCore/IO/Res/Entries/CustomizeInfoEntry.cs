global using CustomizeInfoKeyType = SoulWorkerResearch.SoulCore.Defines.Class;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;
using SoulWorkerResearch.SoulCore.Utils;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record CustomizeInfoEntry : ITableEntry<CustomizeInfoKeyType>
{
    public const string TableName = "tb_Customize_Info";

    public const byte ValueCount = 5;

    public sealed record Value(byte Unknown1, byte Unknown2, string Unknown3);

    public CustomizeInfoKeyType Id { get; }
    public byte Unknown1 { get; }
    public IReadOnlyList<Value> Values { get; }

    public CustomizeInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadClass();
        Unknown1 = reader.ReadByte();
        Values = ReadValues(reader);
    }
    private static IReadOnlyList<Value> ReadValues(BinaryReader reader)
    {
        var unknown1 = reader.ReadByteAsArray(ValueCount);
        var unknown2 = reader.ReadByteAsArray(ValueCount);
        var unknown3 = reader.ReadByteLengthUnicodeStringAsArray(ValueCount);

        return Iterable.Iterate(unknown1, unknown2, unknown3)
            .Select(value => new Value(value.Item1, value.Item2, value.Item3))
            .ToArray();
    }
}

// https://youtu.be/Zrdy_G_Vu4k?list=RDMM