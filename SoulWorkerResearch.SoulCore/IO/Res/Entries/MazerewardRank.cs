global using MazerewardRankKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardRankEntry : IEntry<MazerewardRankEntry>
{
    public const string TableName = "tb_MazeReward_Rank";

    public MazerewardRankKeyType Id { get; set; }
    public byte Field1 { get; set; }

    public MazerewardRankEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
    }

    static string IEntry<MazerewardRankEntry>.TableName => TableName;

    static MazerewardRankEntry IEntry<MazerewardRankEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardRankEntry(reader);
    }
}
