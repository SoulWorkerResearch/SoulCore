global using MazerewardLevelKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardLevelEntry : IEntry<MazerewardLevelEntry>
{
    public const string TableName = "tb_MazeReward_Level";

    public MazerewardLevelKeyType Id { get; set; }

    public MazerewardLevelEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
    }

    static string IEntry<MazerewardLevelEntry>.TableName => TableName;

    static MazerewardLevelEntry IEntry<MazerewardLevelEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardLevelEntry(reader);
    }
}
