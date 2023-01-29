global using CustomizeSkinKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomizeSkinEntry : IEntry<CustomizeSkinEntry>
{
    public const string TableName = "tb_Customize_Skin";

    public CustomizeSkinKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public string Field11 { get; set; } = string.Empty;
    public string Field12 { get; set; } = string.Empty;
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;
    public string Field15 { get; set; } = string.Empty;
    public string Field16 { get; set; } = string.Empty;
    public string Field17 { get; set; } = string.Empty;
    public string Field18 { get; set; } = string.Empty;
    public string Field19 { get; set; } = string.Empty;
    public string Field20 { get; set; } = string.Empty;
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public uint Field27 { get; set; }
    public uint Field28 { get; set; }
    public uint Field29 { get; set; }
    public uint Field30 { get; set; }

    public CustomizeSkinEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
        Field15 = reader.ReadUTF16UnicodeString();
        Field16 = reader.ReadUTF16UnicodeString();
        Field17 = reader.ReadUTF16UnicodeString();
        Field18 = reader.ReadUTF16UnicodeString();
        Field19 = reader.ReadUTF16UnicodeString();
        Field20 = reader.ReadUTF16UnicodeString();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadUInt32();
        Field28 = reader.ReadUInt32();
        Field29 = reader.ReadUInt32();
        Field30 = reader.ReadUInt32();
    }

    static string IEntry<CustomizeSkinEntry>.TableName => TableName;

    static CustomizeSkinEntry IEntry<CustomizeSkinEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomizeSkinEntry(reader);
    }
}
