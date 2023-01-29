global using RankChangeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RankChangeEntry : IEntry<RankChangeEntry>
{
    public const string TableName = "tb_Rank_Change";

    public RankChangeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public short Field2 { get; set; }
    public short Field3 { get; set; }

    public RankChangeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadInt16();
        Field3 = reader.ReadInt16();
    }

    static string IEntry<RankChangeEntry>.TableName => TableName;

    static RankChangeEntry IEntry<RankChangeEntry>.CreateInstance(BinaryReader reader)
    {
        return new RankChangeEntry(reader);
    }
}
