global using GrowthItemExpKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GrowthItemExpEntry : IEntry<GrowthItemExpEntry>
{
    public const string TableName = "tb_Growth_Item_Exp";

    public GrowthItemExpKeyType Id { get; set; }
    public uint Field1 { get; set; }

    public GrowthItemExpEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
    }

    static string IEntry<GrowthItemExpEntry>.TableName => TableName;

    static GrowthItemExpEntry IEntry<GrowthItemExpEntry>.CreateInstance(BinaryReader reader)
    {
        return new GrowthItemExpEntry(reader);
    }
}
