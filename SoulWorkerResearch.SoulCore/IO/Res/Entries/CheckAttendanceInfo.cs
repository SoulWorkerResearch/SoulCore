global using CheckAttendanceInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CheckAttendanceInfoEntry : IEntry<CheckAttendanceInfoEntry>
{
    public const string TableName = "tb_Check_Attendance_Info";

    public CheckAttendanceInfoKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public ushort Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public ushort Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public uint Field9 { get; set; }
    public ushort Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;

    public CheckAttendanceInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CheckAttendanceInfoEntry>.TableName => TableName;

    static CheckAttendanceInfoEntry IEntry<CheckAttendanceInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new CheckAttendanceInfoEntry(reader);
    }
}
