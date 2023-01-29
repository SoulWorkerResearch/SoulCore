global using GrowthExpTransferInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GrowthExpTransferInfoEntry : IEntry<GrowthExpTransferInfoEntry>
{
    public const string TableName = "tb_Growth_Exp_Transfer_Info";

    public GrowthExpTransferInfoKeyType Id { get; set; }
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
    public uint Field11 { get; set; }

    public GrowthExpTransferInfoEntry(BinaryReader reader)
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
        Field11 = reader.ReadUInt32();
    }

    static string IEntry<GrowthExpTransferInfoEntry>.TableName => TableName;

    static GrowthExpTransferInfoEntry IEntry<GrowthExpTransferInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new GrowthExpTransferInfoEntry(reader);
    }
}
