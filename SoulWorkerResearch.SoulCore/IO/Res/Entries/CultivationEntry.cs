global using CultivationKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CultivationEntry : IEntry<CultivationEntry>
{
    public const string TableName = "tb_Cultivation";

    public CultivationKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public string Field10 { get; set; } = string.Empty;
    public string Field11 { get; set; } = string.Empty;
    public string Field12 { get; set; } = string.Empty;
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;

    public CultivationEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CultivationEntry>.TableName => TableName;

    static CultivationEntry IEntry<CultivationEntry>.CreateInstance(BinaryReader reader)
    {
        return new CultivationEntry(reader);
    }
}
