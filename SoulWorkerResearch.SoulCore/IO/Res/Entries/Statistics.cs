global using StatisticsKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class StatisticsEntry : IEntry<StatisticsEntry>
{
    public const string TableName = "tb_Statistics";

    public StatisticsKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }

    public StatisticsEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
    }

    static string IEntry<StatisticsEntry>.TableName => TableName;

    static StatisticsEntry IEntry<StatisticsEntry>.CreateInstance(BinaryReader reader)
    {
        return new StatisticsEntry(reader);
    }
}
