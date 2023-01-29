global using ItemClassrewardLinkKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemClassrewardLinkEntry : IEntry<ItemClassrewardLinkEntry>
{
    public const string TableName = "tb_Item_Classreward_Link";

    public ItemClassrewardLinkKeyType Id { get; set; }
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

    public ItemClassrewardLinkEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
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
    }

    static string IEntry<ItemClassrewardLinkEntry>.TableName => TableName;

    static ItemClassrewardLinkEntry IEntry<ItemClassrewardLinkEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemClassrewardLinkEntry(reader);
    }
}
