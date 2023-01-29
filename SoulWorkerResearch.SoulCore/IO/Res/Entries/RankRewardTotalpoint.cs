global using RankRewardTotalpointKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RankRewardTotalpointEntry : IEntry<RankRewardTotalpointEntry>
{
    public const string TableName = "tb_Rank_Reward_Totalpoint";

    public RankRewardTotalpointKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public ushort Field5 { get; set; }
    public uint Field6 { get; set; }

    public RankRewardTotalpointEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt32();
    }

    static string IEntry<RankRewardTotalpointEntry>.TableName => TableName;

    static RankRewardTotalpointEntry IEntry<RankRewardTotalpointEntry>.CreateInstance(BinaryReader reader)
    {
        return new RankRewardTotalpointEntry(reader);
    }
}
