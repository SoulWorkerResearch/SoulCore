global using RankTierKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RankTierEntry : IEntry<RankTierEntry>
{
    public const string TableName = "tb_Rank_Tier";

    public RankTierKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }

    public RankTierEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
    }

    static string IEntry<RankTierEntry>.TableName => TableName;

    static RankTierEntry IEntry<RankTierEntry>.CreateInstance(BinaryReader reader)
    {
        return new RankTierEntry(reader);
    }
}
