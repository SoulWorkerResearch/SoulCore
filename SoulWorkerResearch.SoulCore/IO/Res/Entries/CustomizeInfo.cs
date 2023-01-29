global using CustomizeInfoKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomizeInfoEntry : IEntry<CustomizeInfoEntry>
{
    public const string TableName = "tb_Customize_Info";

    public CustomizeInfoKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public string Field12 { get; set; } = string.Empty;
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;
    public string Field15 { get; set; } = string.Empty;
    public string Field16 { get; set; } = string.Empty;

    public CustomizeInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
        Field15 = reader.ReadUTF16UnicodeString();
        Field16 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CustomizeInfoEntry>.TableName => TableName;

    static CustomizeInfoEntry IEntry<CustomizeInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomizeInfoEntry(reader);
    }
}
