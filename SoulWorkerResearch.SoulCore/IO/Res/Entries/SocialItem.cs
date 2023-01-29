global using SocialItemKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SocialItemEntry : IEntry<SocialItemEntry>
{
    public const string TableName = "tb_Social_Item";

    public SocialItemKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public uint Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public string Field9 { get; set; } = string.Empty;
    public string Field10 { get; set; } = string.Empty;
    public string Field11 { get; set; } = string.Empty;
    public short Field12 { get; set; }
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;
    public short Field15 { get; set; }
    public string Field16 { get; set; } = string.Empty;
    public uint Field17 { get; set; }
    public byte Field18 { get; set; }

    public SocialItemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadInt16();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
        Field15 = reader.ReadInt16();
        Field16 = reader.ReadUTF16UnicodeString();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadByte();
    }

    static string IEntry<SocialItemEntry>.TableName => TableName;

    static SocialItemEntry IEntry<SocialItemEntry>.CreateInstance(BinaryReader reader)
    {
        return new SocialItemEntry(reader);
    }
}
