global using ModeDistrict6KeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeDistrict6Entry : IEntry<ModeDistrict6Entry>
{
    public const string TableName = "tb_Mode_District6";

    public ModeDistrict6KeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public ushort Field3 { get; set; }
    public uint Field4 { get; set; }
    public ushort Field5 { get; set; }
    public uint Field6 { get; set; }
    public ushort Field7 { get; set; }
    public uint Field8 { get; set; }
    public ushort Field9 { get; set; }
    public byte Field10 { get; set; }
    public string Field11 { get; set; } = string.Empty;
    public string Field12 { get; set; } = string.Empty;
    public string Field13 { get; set; } = string.Empty;
    public ushort Field14 { get; set; }
    public byte Field15 { get; set; }
    public uint Field16 { get; set; }
    public uint Field17 { get; set; }
    public uint Field18 { get; set; }
    public uint Field19 { get; set; }
    public uint Field20 { get; set; }
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public ushort Field26 { get; set; }
    public ushort Field27 { get; set; }
    public ushort Field28 { get; set; }
    public ushort Field29 { get; set; }
    public ushort Field30 { get; set; }
    public ushort Field31 { get; set; }
    public ushort Field32 { get; set; }
    public ushort Field33 { get; set; }
    public ushort Field34 { get; set; }
    public ushort Field35 { get; set; }
    public ushort Field36 { get; set; }
    public ushort Field37 { get; set; }
    public ushort Field38 { get; set; }

    public ModeDistrict6Entry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadUInt32();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt16();
        Field27 = reader.ReadUInt16();
        Field28 = reader.ReadUInt16();
        Field29 = reader.ReadUInt16();
        Field30 = reader.ReadUInt16();
        Field31 = reader.ReadUInt16();
        Field32 = reader.ReadUInt16();
        Field33 = reader.ReadUInt16();
        Field34 = reader.ReadUInt16();
        Field35 = reader.ReadUInt16();
        Field36 = reader.ReadUInt16();
        Field37 = reader.ReadUInt16();
        Field38 = reader.ReadUInt16();
    }

    static string IEntry<ModeDistrict6Entry>.TableName => TableName;

    static ModeDistrict6Entry IEntry<ModeDistrict6Entry>.CreateInstance(BinaryReader reader)
    {
        return new ModeDistrict6Entry(reader);
    }
}
