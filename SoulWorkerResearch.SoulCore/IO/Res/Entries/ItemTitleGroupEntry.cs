global using ItemTitleGroupKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemTitleGroupEntry : IEntry<ItemTitleGroupEntry>
{
    public const string TableName = "tb_item_Title_Group";

    public ItemTitleGroupKeyType Id { get; set; }
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
    public short Field11 { get; set; }
    public short Field12 { get; set; }
    public short Field13 { get; set; }
    public short Field14 { get; set; }
    public short Field15 { get; set; }
    public short Field16 { get; set; }
    public short Field17 { get; set; }
    public short Field18 { get; set; }
    public short Field19 { get; set; }
    public short Field20 { get; set; }

    public ItemTitleGroupEntry(BinaryReader reader)
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
        Field11 = reader.ReadInt16();
        Field12 = reader.ReadInt16();
        Field13 = reader.ReadInt16();
        Field14 = reader.ReadInt16();
        Field15 = reader.ReadInt16();
        Field16 = reader.ReadInt16();
        Field17 = reader.ReadInt16();
        Field18 = reader.ReadInt16();
        Field19 = reader.ReadInt16();
        Field20 = reader.ReadInt16();
    }

    static string IEntry<ItemTitleGroupEntry>.TableName => TableName;

    static ItemTitleGroupEntry IEntry<ItemTitleGroupEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemTitleGroupEntry(reader);
    }
}
