global using CustomerGradeKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomerGradeEntry : IEntry<CustomerGradeEntry>
{
    public const string TableName = "tb_Customer_Grade";

    public CustomerGradeKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }
    public byte Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }

    public CustomerGradeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
    }

    static string IEntry<CustomerGradeEntry>.TableName => TableName;

    static CustomerGradeEntry IEntry<CustomerGradeEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomerGradeEntry(reader);
    }
}
