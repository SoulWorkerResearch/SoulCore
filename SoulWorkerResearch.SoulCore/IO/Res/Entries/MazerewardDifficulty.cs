global using MazerewardDifficultyKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardDifficultyEntry : IEntry<MazerewardDifficultyEntry>
{
    public const string TableName = "tb_MazeReward_Difficulty";

    public MazerewardDifficultyKeyType Id { get; set; }

    public MazerewardDifficultyEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
    }

    static string IEntry<MazerewardDifficultyEntry>.TableName => TableName;

    static MazerewardDifficultyEntry IEntry<MazerewardDifficultyEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardDifficultyEntry(reader);
    }
}
