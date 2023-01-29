global using LeagueBoosterKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LeagueBoosterEntry : IEntry<LeagueBoosterEntry>
{
    public const string TableName = "tb_League_Booster";

    public LeagueBoosterKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }

    public LeagueBoosterEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
    }

    static string IEntry<LeagueBoosterEntry>.TableName => TableName;

    static LeagueBoosterEntry IEntry<LeagueBoosterEntry>.CreateInstance(BinaryReader reader)
    {
        return new LeagueBoosterEntry(reader);
    }
}
