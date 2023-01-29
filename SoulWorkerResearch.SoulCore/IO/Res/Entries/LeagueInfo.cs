global using LeagueInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LeagueInfoEntry : IEntry<LeagueInfoEntry>
{
    public const string TableName = "tb_League_Info";

    public LeagueInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }

    public LeagueInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
    }

    static string IEntry<LeagueInfoEntry>.TableName => TableName;

    static LeagueInfoEntry IEntry<LeagueInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new LeagueInfoEntry(reader);
    }
}