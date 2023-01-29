global using MazerewardPartyvalueKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardPartyvalueEntry : IEntry<MazerewardPartyvalueEntry>
{
    public const string TableName = "tb_MazeReward_PartyValue";

    public MazerewardPartyvalueKeyType Id { get; set; }

    public MazerewardPartyvalueEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
    }

    static string IEntry<MazerewardPartyvalueEntry>.TableName => TableName;

    static MazerewardPartyvalueEntry IEntry<MazerewardPartyvalueEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardPartyvalueEntry(reader);
    }
}
