global using CustomizeHairKeyType = SoulWorkerResearch.SoulCore.Defines.Class;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;
using SoulWorkerResearch.SoulCore.Utils;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record CustomizeHairEntry : ITableEntry<CustomizeHairKeyType>
{
    public const string TableName = "tb_Customize_Hair";

    public const byte ValueCount = 10;

    public sealed record Value(uint Unknown1, uint Style, uint Unknown2, string Icons, uint Color);

    public CustomizeHairKeyType Id { get; }
    public IReadOnlyList<Value> Values { get; }

    public CustomizeHairEntry(BinaryReader reader) => (Id, Values) = (reader.ReadClass(), ReadValues(reader));

    private static IReadOnlyList<Value> ReadValues(BinaryReader br)
    {
        var unknown1 = br.ReadUInt32AsArray(ValueCount);
        var style = br.ReadUInt32AsArray(ValueCount);
        var unknown2 = br.ReadUInt32AsArray(ValueCount);
        var icons = br.ReadByteLengthUnicodeStringAsArray(ValueCount);
        var color = br.ReadUInt32AsArray(ValueCount);

        return Iterable.Zip(unknown1, style, unknown2, icons, color)
            .Select(value => new Value(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5))
            .ToArray();
    }
}
