global using AkashicRecordsKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AkashicRecordsEntry : IEntry<AkashicRecordsEntry>
{
    public const string TableName = "tb_Akashic_Records";

    public AkashicRecordsKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public ushort Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public string Field12 { get; set; } = string.Empty;
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public string Field18 { get; set; } = string.Empty;
    public ushort Field19 { get; set; }
    public byte Field20 { get; set; }
    public uint Field21 { get; set; }
    public byte Field22 { get; set; }
    public ushort Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public byte Field27 { get; set; }
    public ushort Field28 { get; set; }
    public byte Field29 { get; set; }
    public uint Field30 { get; set; }
    public uint Field31 { get; set; }
    public uint Field32 { get; set; }
    public uint Field33 { get; set; }
    public uint Field34 { get; set; }
    public byte Field35 { get; set; }
    public uint Field36 { get; set; }
    public uint Field37 { get; set; }
    public uint Field38 { get; set; }
    public uint Field39 { get; set; }
    public byte Field40 { get; set; }
    public byte Field41 { get; set; }
    public byte Field42 { get; set; }
    public ushort Field43 { get; set; }
    public ushort Field44 { get; set; }

    public AkashicRecordsEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUTF16UnicodeString();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadUInt16();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadByte();
        Field28 = reader.ReadUInt16();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadUInt32();
        Field31 = reader.ReadUInt32();
        Field32 = reader.ReadUInt32();
        Field33 = reader.ReadUInt32();
        Field34 = reader.ReadUInt32();
        Field35 = reader.ReadByte();
        Field36 = reader.ReadUInt32();
        Field37 = reader.ReadUInt32();
        Field38 = reader.ReadUInt32();
        Field39 = reader.ReadUInt32();
        Field40 = reader.ReadByte();
        Field41 = reader.ReadByte();
        Field42 = reader.ReadByte();
        Field43 = reader.ReadUInt16();
        Field44 = reader.ReadUInt16();
    }

    static string IEntry<AkashicRecordsEntry>.TableName => TableName;

    static AkashicRecordsEntry IEntry<AkashicRecordsEntry>.CreateInstance(BinaryReader reader)
    {
        return new AkashicRecordsEntry(reader);
    }
}
