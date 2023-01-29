global using ClassselectInfoKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ClassselectInfoEntry : IEntry<ClassselectInfoEntry>
{
    public const string TableName = "tb_ClassSelect_Info";

    public ClassselectInfoKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public int Field18 { get; set; }
    public ushort Field19 { get; set; }
    public string Field20 { get; set; } = string.Empty;
    public string Field21 { get; set; } = string.Empty;
    public string Field22 { get; set; } = string.Empty;
    public string Field23 { get; set; } = string.Empty;
    public string Field24 { get; set; } = string.Empty;
    public string Field25 { get; set; } = string.Empty;

    public ClassselectInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadInt32();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadUTF16UnicodeString();
        Field21 = reader.ReadUTF16UnicodeString();
        Field22 = reader.ReadUTF16UnicodeString();
        Field23 = reader.ReadUTF16UnicodeString();
        Field24 = reader.ReadUTF16UnicodeString();
        Field25 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<ClassselectInfoEntry>.TableName => TableName;

    static ClassselectInfoEntry IEntry<ClassselectInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new ClassselectInfoEntry(reader);
    }
}
