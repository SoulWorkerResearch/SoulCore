global using ItemLimitKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemLimitEntry : IEntry<ItemLimitEntry>
{
    public const string TableName = "tb_item_limit";

    public ItemLimitKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }

    public ItemLimitEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
    }

    static string IEntry<ItemLimitEntry>.TableName => TableName;

    static ItemLimitEntry IEntry<ItemLimitEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemLimitEntry(reader);
    }
}
