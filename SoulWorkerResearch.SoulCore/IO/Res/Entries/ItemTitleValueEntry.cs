global using ItemTitleValueKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemTitleValueEntry : IEntry<ItemTitleValueEntry>
{
    public const string TableName = "tb_item_Title_Value";

    public ItemTitleValueKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public short Field8 { get; set; }
    public short Field9 { get; set; }
    public short Field10 { get; set; }

    public ItemTitleValueEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadInt16();
        Field9 = reader.ReadInt16();
        Field10 = reader.ReadInt16();
    }

    static string IEntry<ItemTitleValueEntry>.TableName => TableName;

    static ItemTitleValueEntry IEntry<ItemTitleValueEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemTitleValueEntry(reader);
    }
}
