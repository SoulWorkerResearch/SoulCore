global using RspEventKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RspEventEntry : IEntry<RspEventEntry>
{
    public const string TableName = "tb_RSP_Event";

    public RspEventKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public string Field9 { get; set; } = string.Empty;
    public uint Field10 { get; set; }
    public ushort Field11 { get; set; }
    public uint Field12 { get; set; }
    public ushort Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
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
    public ushort Field39 { get; set; }
    public ushort Field40 { get; set; }
    public ushort Field41 { get; set; }
    public ushort Field42 { get; set; }
    public ushort Field43 { get; set; }
    public ushort Field44 { get; set; }
    public ushort Field45 { get; set; }
    public ushort Field46 { get; set; }
    public ushort Field47 { get; set; }
    public ushort Field48 { get; set; }
    public ushort Field49 { get; set; }

    public RspEventEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
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
        Field39 = reader.ReadUInt16();
        Field40 = reader.ReadUInt16();
        Field41 = reader.ReadUInt16();
        Field42 = reader.ReadUInt16();
        Field43 = reader.ReadUInt16();
        Field44 = reader.ReadUInt16();
        Field45 = reader.ReadUInt16();
        Field46 = reader.ReadUInt16();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadUInt16();
        Field49 = reader.ReadUInt16();
    }

    static string IEntry<RspEventEntry>.TableName => TableName;

    static RspEventEntry IEntry<RspEventEntry>.CreateInstance(BinaryReader reader)
    {
        return new RspEventEntry(reader);
    }
}
