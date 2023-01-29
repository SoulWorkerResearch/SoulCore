global using RankRewardKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RankRewardEntry : IEntry<RankRewardEntry>
{
    public const string TableName = "tb_Rank_Reward";

    public RankRewardKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public ushort Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public uint Field17 { get; set; }
    public uint Field18 { get; set; }
    public uint Field19 { get; set; }

    public RankRewardEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadUInt32();
    }

    static string IEntry<RankRewardEntry>.TableName => TableName;

    static RankRewardEntry IEntry<RankRewardEntry>.CreateInstance(BinaryReader reader)
    {
        return new RankRewardEntry(reader);
    }
}
