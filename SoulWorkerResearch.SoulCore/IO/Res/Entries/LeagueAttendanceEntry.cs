global using LeagueAttendanceKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LeagueAttendanceEntry : IEntry<LeagueAttendanceEntry>
{
    public const string TableName = "tb_League_Attendance";

    public LeagueAttendanceKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }

    public LeagueAttendanceEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
    }

    static string IEntry<LeagueAttendanceEntry>.TableName => TableName;

    static LeagueAttendanceEntry IEntry<LeagueAttendanceEntry>.CreateInstance(BinaryReader reader)
    {
        return new LeagueAttendanceEntry(reader);
    }
}
