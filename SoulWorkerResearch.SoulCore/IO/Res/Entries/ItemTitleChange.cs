global using ItemTitleChangeKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemTitleChangeEntry : IEntry<ItemTitleChangeEntry>
{
    public const string TableName = "tb_Item_Title_Change";

    public ItemTitleChangeKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }

    public ItemTitleChangeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
    }

    static string IEntry<ItemTitleChangeEntry>.TableName => TableName;

    static ItemTitleChangeEntry IEntry<ItemTitleChangeEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemTitleChangeEntry(reader);
    }
}
