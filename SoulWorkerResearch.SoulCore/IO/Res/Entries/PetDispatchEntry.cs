global using PetDispatchKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetDispatchEntry : IEntry<PetDispatchEntry>
{
    public const string TableName = "tb_Pet_Dispatch";

    public PetDispatchKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public byte Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public ushort Field19 { get; set; }
    public ushort Field20 { get; set; }
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public byte Field23 { get; set; }
    public byte Field24 { get; set; }
    public byte Field25 { get; set; }
    public byte Field26 { get; set; }

    public PetDispatchEntry(BinaryReader reader)
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
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadUInt16();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadByte();
        Field24 = reader.ReadByte();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadByte();
    }

    static string IEntry<PetDispatchEntry>.TableName => TableName;

    static PetDispatchEntry IEntry<PetDispatchEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetDispatchEntry(reader);
    }
}
