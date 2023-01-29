global using ModeDistrict6DateKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeDistrict6DateEntry : IEntry<ModeDistrict6DateEntry>
{
    public const string TableName = "tb_Mode_District6_Date";

    public ModeDistrict6DateKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public ushort Field10 { get; set; }
    public ushort Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public uint Field17 { get; set; }
    public string Field18 { get; set; } = string.Empty;
    public string Field19 { get; set; } = string.Empty;
    public uint Field20 { get; set; }
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }

    public ModeDistrict6DateEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadUTF16UnicodeString();
        Field19 = reader.ReadUTF16UnicodeString();
        Field20 = reader.ReadUInt32();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
    }

    static string IEntry<ModeDistrict6DateEntry>.TableName => TableName;

    static ModeDistrict6DateEntry IEntry<ModeDistrict6DateEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeDistrict6DateEntry(reader);
    }
}
