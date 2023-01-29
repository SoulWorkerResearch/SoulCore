global using CashshopKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CashshopEntry : IEntry<CashshopEntry>
{
    public const string TableName = "tb_CashShop";

    public CashshopKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public uint Field8 { get; set; }
    public byte Field9 { get; set; }
    public string Field10 { get; set; } = string.Empty;
    public string Field11 { get; set; } = string.Empty;
    public byte Field12 { get; set; }
    public ushort Field13 { get; set; }
    public byte Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public byte Field23 { get; set; }
    public string Field24 { get; set; } = string.Empty;
    public byte Field25 { get; set; }
    public uint Field26 { get; set; }

    public CashshopEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadByte();
        Field24 = reader.ReadUTF16UnicodeString();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadUInt32();
    }

    static string IEntry<CashshopEntry>.TableName => TableName;

    static CashshopEntry IEntry<CashshopEntry>.CreateInstance(BinaryReader reader)
    {
        return new CashshopEntry(reader);
    }
}
