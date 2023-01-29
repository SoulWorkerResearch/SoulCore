global using ItemSubmodelKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemSubmodelEntry : IEntry<ItemSubmodelEntry>
{
    public const string TableName = "tb_Item_SubModel";

    public ItemSubmodelKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }

    public ItemSubmodelEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
    }

    static string IEntry<ItemSubmodelEntry>.TableName => TableName;

    static ItemSubmodelEntry IEntry<ItemSubmodelEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemSubmodelEntry(reader);
    }
}
