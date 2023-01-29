global using MazerewardTimeKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardTimeEntry : IEntry<MazerewardTimeEntry>
{
    public const string TableName = "tb_MazeReward_Time";

    public MazerewardTimeKeyType Id { get; set; }

    public MazerewardTimeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
    }

    static string IEntry<MazerewardTimeEntry>.TableName => TableName;

    static MazerewardTimeEntry IEntry<MazerewardTimeEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardTimeEntry(reader);
    }
}
