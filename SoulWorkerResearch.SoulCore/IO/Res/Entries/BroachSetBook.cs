global using BroachSetBookKeyType = System.Int32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BroachSetBookEntry : IEntry<BroachSetBookEntry>
{
    public const string TableName = "Tb_Broach_set_book";

    public BroachSetBookKeyType Id { get; set; }
    public int Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public uint Field3 { get; set; }
    public int Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }

    public BroachSetBookEntry(BinaryReader reader)
    {
        Id = reader.ReadInt32();
        Field1 = reader.ReadInt32();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
    }

    static string IEntry<BroachSetBookEntry>.TableName => TableName;

    static BroachSetBookEntry IEntry<BroachSetBookEntry>.CreateInstance(BinaryReader reader)
    {
        return new BroachSetBookEntry(reader);
    }
}
