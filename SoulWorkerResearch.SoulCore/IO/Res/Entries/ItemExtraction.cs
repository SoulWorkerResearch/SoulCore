global using ItemExtractionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemExtractionEntry : IEntry<ItemExtractionEntry>
{
    public const string TableName = "tb_item_extraction";

    public ItemExtractionKeyType Id { get; set; }
    public uint Field1 { get; set; }

    public ItemExtractionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
    }

    static string IEntry<ItemExtractionEntry>.TableName => TableName;

    static ItemExtractionEntry IEntry<ItemExtractionEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemExtractionEntry(reader);
    }
}
