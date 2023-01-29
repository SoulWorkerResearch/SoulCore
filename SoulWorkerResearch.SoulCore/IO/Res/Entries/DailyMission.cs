global using DailyMissionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DailyMissionEntry : IEntry<DailyMissionEntry>
{
    public const string TableName = "tb_Daily_Mission";

    public DailyMissionKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public uint Field6 { get; set; }
    public byte Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public byte Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public byte Field13 { get; set; }
    public byte Field14 { get; set; }
    public string Field15 { get; set; } = string.Empty;
    public string Field16 { get; set; } = string.Empty;
    public uint Field17 { get; set; }
    public uint Field18 { get; set; }
    public uint Field19 { get; set; }
    public uint Field20 { get; set; }
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public byte Field23 { get; set; }
    public byte Field24 { get; set; }
    public byte Field25 { get; set; }
    public uint Field26 { get; set; }

    public DailyMissionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadUTF16UnicodeString();
        Field16 = reader.ReadUTF16UnicodeString();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadUInt32();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadByte();
        Field24 = reader.ReadByte();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadUInt32();
    }

    static string IEntry<DailyMissionEntry>.TableName => TableName;

    static DailyMissionEntry IEntry<DailyMissionEntry>.CreateInstance(BinaryReader reader)
    {
        return new DailyMissionEntry(reader);
    }
}
