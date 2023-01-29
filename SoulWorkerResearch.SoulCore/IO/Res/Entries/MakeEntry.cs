global using MakeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MakeEntry : IEntry<MakeEntry>
{
    public const string TableName = "tb_Make";

    public MakeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public ushort Field11 { get; set; }
    public ushort Field12 { get; set; }
    public ushort Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public uint Field16 { get; set; }
    public ushort Field17 { get; set; }
    public byte Field18 { get; set; }
    public ushort Field19 { get; set; }
    public byte Field20 { get; set; }

    public MakeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadByte();
    }

    static string IEntry<MakeEntry>.TableName => TableName;

    static MakeEntry IEntry<MakeEntry>.CreateInstance(BinaryReader reader)
    {
        return new MakeEntry(reader);
    }
}
