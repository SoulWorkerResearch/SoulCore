global using ItemCountboxGroupKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemCountboxGroupEntry : IEntry<ItemCountboxGroupEntry>
{
    public const string TableName = "tb_Item_CountBox_Group";

    public ItemCountboxGroupKeyType Id { get; set; }
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
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public byte Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public byte Field23 { get; set; }
    public byte Field24 { get; set; }
    public byte Field25 { get; set; }
    public byte Field26 { get; set; }
    public byte Field27 { get; set; }
    public byte Field28 { get; set; }
    public byte Field29 { get; set; }
    public byte Field30 { get; set; }

    public ItemCountboxGroupEntry(BinaryReader reader)
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
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadByte();
        Field24 = reader.ReadByte();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadByte();
        Field27 = reader.ReadByte();
        Field28 = reader.ReadByte();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadByte();
    }

    static string IEntry<ItemCountboxGroupEntry>.TableName => TableName;

    static ItemCountboxGroupEntry IEntry<ItemCountboxGroupEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemCountboxGroupEntry(reader);
    }
}
