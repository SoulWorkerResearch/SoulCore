global using GrowthItemSpecialInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GrowthItemSpecialInfoEntry : IEntry<GrowthItemSpecialInfoEntry>
{
    public const string TableName = "tb_Growth_Item_Special_Info";

    public GrowthItemSpecialInfoKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }

    public GrowthItemSpecialInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
    }

    static string IEntry<GrowthItemSpecialInfoEntry>.TableName => TableName;

    static GrowthItemSpecialInfoEntry IEntry<GrowthItemSpecialInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new GrowthItemSpecialInfoEntry(reader);
    }
}
