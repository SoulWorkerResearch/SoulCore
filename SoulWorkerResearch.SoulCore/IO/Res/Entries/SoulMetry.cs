global using SoulMetryKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SoulMetryEntry : IEntry<SoulMetryEntry>
{
    public const string TableName = "tb_soul_metry";

    public SoulMetryKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public string Field19 { get; set; } = string.Empty;
    public string Field20 { get; set; } = string.Empty;
    public string Field21 { get; set; } = string.Empty;
    public string Field22 { get; set; } = string.Empty;
    public string Field23 { get; set; } = string.Empty;
    public ushort Field24 { get; set; }
    public ushort Field25 { get; set; }
    public ushort Field26 { get; set; }
    public ushort Field27 { get; set; }
    public ushort Field28 { get; set; }
    public byte Field29 { get; set; }
    public byte Field30 { get; set; }
    public uint Field31 { get; set; }
    public uint Field32 { get; set; }
    public byte Field33 { get; set; }
    public byte Field34 { get; set; }
    public uint Field35 { get; set; }
    public uint Field36 { get; set; }
    public uint Field37 { get; set; }
    public uint Field38 { get; set; }
    public uint Field39 { get; set; }
    public uint Field40 { get; set; }
    public ushort Field41 { get; set; }

    public SoulMetryEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadUTF16UnicodeString();
        Field20 = reader.ReadUTF16UnicodeString();
        Field21 = reader.ReadUTF16UnicodeString();
        Field22 = reader.ReadUTF16UnicodeString();
        Field23 = reader.ReadUTF16UnicodeString();
        Field24 = reader.ReadUInt16();
        Field25 = reader.ReadUInt16();
        Field26 = reader.ReadUInt16();
        Field27 = reader.ReadUInt16();
        Field28 = reader.ReadUInt16();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadByte();
        Field31 = reader.ReadUInt32();
        Field32 = reader.ReadUInt32();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadByte();
        Field35 = reader.ReadUInt32();
        Field36 = reader.ReadUInt32();
        Field37 = reader.ReadUInt32();
        Field38 = reader.ReadUInt32();
        Field39 = reader.ReadUInt32();
        Field40 = reader.ReadUInt32();
        Field41 = reader.ReadUInt16();
    }

    static string IEntry<SoulMetryEntry>.TableName => TableName;

    static SoulMetryEntry IEntry<SoulMetryEntry>.CreateInstance(BinaryReader reader)
    {
        return new SoulMetryEntry(reader);
    }
}
