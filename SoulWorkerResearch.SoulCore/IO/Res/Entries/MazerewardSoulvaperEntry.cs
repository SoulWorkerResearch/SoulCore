global using MazerewardSoulvaperKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardSoulvaperEntry : IEntry<MazerewardSoulvaperEntry>
{
    public const string TableName = "tb_MazeReward_SoulVaper";

    public MazerewardSoulvaperKeyType Id { get; set; }

    public MazerewardSoulvaperEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
    }

    static string IEntry<MazerewardSoulvaperEntry>.TableName => TableName;

    static MazerewardSoulvaperEntry IEntry<MazerewardSoulvaperEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardSoulvaperEntry(reader);
    }
}
