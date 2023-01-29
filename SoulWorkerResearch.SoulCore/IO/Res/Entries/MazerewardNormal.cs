global using MazerewardNormalKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardNormalEntry : IEntry<MazerewardNormalEntry>
{
    public const string TableName = "tb_MazeReward_Normal";

    public MazerewardNormalKeyType Id { get; set; }

    public MazerewardNormalEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
    }

    static string IEntry<MazerewardNormalEntry>.TableName => TableName;

    static MazerewardNormalEntry IEntry<MazerewardNormalEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardNormalEntry(reader);
    }
}
