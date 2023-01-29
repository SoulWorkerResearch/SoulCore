global using ItemCostumesetKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemCostumesetEntry : IEntry<ItemCostumesetEntry>
{
    public const string TableName = "tb_Item_CostumeSet";

    public ItemCostumesetKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public byte Field9 { get; set; }
    public uint Field10 { get; set; }
    public byte Field11 { get; set; }
    public uint Field12 { get; set; }
    public byte Field13 { get; set; }
    public uint Field14 { get; set; }
    public byte Field15 { get; set; }
    public uint Field16 { get; set; }
    public byte Field17 { get; set; }
    public uint Field18 { get; set; }
    public byte Field19 { get; set; }
    public uint Field20 { get; set; }

    public ItemCostumesetEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadUInt32();
    }

    static string IEntry<ItemCostumesetEntry>.TableName => TableName;

    static ItemCostumesetEntry IEntry<ItemCostumesetEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemCostumesetEntry(reader);
    }
}
