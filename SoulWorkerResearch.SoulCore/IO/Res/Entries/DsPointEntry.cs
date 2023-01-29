global using DsPointKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DsPointEntry : IEntry<DsPointEntry>
{
    public const string TableName = "tb_DS_Point";

    public DsPointKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public ushort Field9 { get; set; }
    public ushort Field10 { get; set; }
    public ushort Field11 { get; set; }
    public ushort Field12 { get; set; }
    public ushort Field13 { get; set; }
    public byte Field14 { get; set; }
    public byte Field15 { get; set; }
    public byte Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public uint Field19 { get; set; }
    public uint Field20 { get; set; }
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public byte Field24 { get; set; }
    public byte Field25 { get; set; }
    public byte Field26 { get; set; }
    public byte Field27 { get; set; }
    public byte Field28 { get; set; }

    public DsPointEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadUInt32();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadByte();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadByte();
        Field27 = reader.ReadByte();
        Field28 = reader.ReadByte();
    }

    static string IEntry<DsPointEntry>.TableName => TableName;

    static DsPointEntry IEntry<DsPointEntry>.CreateInstance(BinaryReader reader)
    {
        return new DsPointEntry(reader);
    }
}
