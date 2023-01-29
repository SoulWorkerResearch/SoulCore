global using InvenSlotExtendKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class InvenSlotExtendEntry : IEntry<InvenSlotExtendEntry>
{
    public const string TableName = "tb_Inven_Slot_Extend";

    public InvenSlotExtendKeyType Id { get; set; }
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
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public uint Field14 { get; set; }
    public byte Field15 { get; set; }
    public ushort Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public uint Field19 { get; set; }
    public byte Field20 { get; set; }
    public ushort Field21 { get; set; }

    public InvenSlotExtendEntry(BinaryReader reader)
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
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadUInt16();
    }

    static string IEntry<InvenSlotExtendEntry>.TableName => TableName;

    static InvenSlotExtendEntry IEntry<InvenSlotExtendEntry>.CreateInstance(BinaryReader reader)
    {
        return new InvenSlotExtendEntry(reader);
    }
}
