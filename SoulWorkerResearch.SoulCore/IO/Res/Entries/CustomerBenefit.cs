global using CustomerBenefitKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomerBenefitEntry : IEntry<CustomerBenefitEntry>
{
    public const string TableName = "tb_Customer_Benefit";

    public CustomerBenefitKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }

    public CustomerBenefitEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
    }

    static string IEntry<CustomerBenefitEntry>.TableName => TableName;

    static CustomerBenefitEntry IEntry<CustomerBenefitEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomerBenefitEntry(reader);
    }
}
