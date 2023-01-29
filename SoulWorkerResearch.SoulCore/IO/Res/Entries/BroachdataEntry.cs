global using BroachdataKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BroachdataEntry : IEntry<BroachdataEntry>
{
    public const string TableName = "TB_BroachData";

    public BroachdataKeyType Id { get; set; }
    public uint Field1 { get; set; }

    public BroachdataEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
    }

    static string IEntry<BroachdataEntry>.TableName => TableName;

    static BroachdataEntry IEntry<BroachdataEntry>.CreateInstance(BinaryReader reader)
    {
        return new BroachdataEntry(reader);
    }
}
