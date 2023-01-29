global using PollenKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PollenEntry : IEntry<PollenEntry>
{
    public const string TableName = "tb_Pollen";

    public PollenKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public string Field6 { get; set; } = string.Empty;
    public uint Field7 { get; set; }

    public PollenEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUInt32();
    }

    static string IEntry<PollenEntry>.TableName => TableName;

    static PollenEntry IEntry<PollenEntry>.CreateInstance(BinaryReader reader)
    {
        return new PollenEntry(reader);
    }
}
