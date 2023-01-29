global using LeagueMarkKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LeagueMarkEntry : IEntry<LeagueMarkEntry>
{
    public const string TableName = "tb_League_Mark";

    public LeagueMarkKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;

    public LeagueMarkEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<LeagueMarkEntry>.TableName => TableName;

    static LeagueMarkEntry IEntry<LeagueMarkEntry>.CreateInstance(BinaryReader reader)
    {
        return new LeagueMarkEntry(reader);
    }
}
