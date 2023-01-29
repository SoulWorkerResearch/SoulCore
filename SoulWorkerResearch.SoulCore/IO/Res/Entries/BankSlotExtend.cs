global using BankSlotExtendKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BankSlotExtendEntry : IEntry<BankSlotExtendEntry>
{
    public const string TableName = "tb_Bank_Slot_Extend";

    public BankSlotExtendKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public ushort Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public uint Field9 { get; set; }
    public byte Field10 { get; set; }
    public ushort Field11 { get; set; }

    public BankSlotExtendEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUInt16();
    }

    static string IEntry<BankSlotExtendEntry>.TableName => TableName;

    static BankSlotExtendEntry IEntry<BankSlotExtendEntry>.CreateInstance(BinaryReader reader)
    {
        return new BankSlotExtendEntry(reader);
    }
}
