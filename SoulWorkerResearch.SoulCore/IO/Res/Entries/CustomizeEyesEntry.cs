global using CustomizeEyesKeyType = SoulWorkerResearch.SoulCore.Defines.Class;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;
using SoulWorkerResearch.SoulCore.Utils;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record CustomizeEyesEntry : ITableEntry<CustomizeEyesKeyType>
{
    public const string TableName = "tb_Customize_Eyes";

    public const byte ValueCount = 10;

    public sealed record Value(uint Unknown1, string Icons, uint Color);

    public CustomizeEyesKeyType Id { get; }
    public IReadOnlyList<Value> Values { get; }

    public CustomizeEyesEntry(BinaryReader reader) => (Id, Values) = (reader.ReadClass(), ReadValues(reader));

    private static IReadOnlyList<Value> ReadValues(BinaryReader reader)
    {
        var unknown1 = reader.ReadUInt32AsArray(ValueCount);
        var icons = reader.ReadByteLengthUnicodeStringAsArray(ValueCount);
        var colors = reader.ReadUInt32AsArray(ValueCount);

        return Iterable.Iterate(unknown1, icons, colors)
            .Select(value => new Value(value.Item1, value.Item2, value.Item3))
            .ToArray();
    }
}
