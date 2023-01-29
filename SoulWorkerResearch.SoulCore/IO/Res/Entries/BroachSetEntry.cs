global using BroachSetKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BroachSetEntry : IEntry<BroachSetEntry>
{
    public const string TableName = "Tb_Broach_Set";

    public BroachSetKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;

    public BroachSetEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<BroachSetEntry>.TableName => TableName;

    static BroachSetEntry IEntry<BroachSetEntry>.CreateInstance(BinaryReader reader)
    {
        return new BroachSetEntry(reader);
    }
}
