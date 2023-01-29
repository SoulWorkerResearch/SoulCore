global using DailymazePortalKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DailymazePortalEntry : IEntry<DailymazePortalEntry>
{
    public const string TableName = "tb_DailyMaze_Portal";

    public DailymazePortalKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public ushort Field10 { get; set; }
    public ushort Field11 { get; set; }
    public ushort Field12 { get; set; }
    public ushort Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public ushort Field19 { get; set; }
    public ushort Field20 { get; set; }
    public ushort Field21 { get; set; }
    public ushort Field22 { get; set; }
    public ushort Field23 { get; set; }
    public ushort Field24 { get; set; }
    public ushort Field25 { get; set; }
    public ushort Field26 { get; set; }
    public ushort Field27 { get; set; }
    public ushort Field28 { get; set; }
    public ushort Field29 { get; set; }
    public ushort Field30 { get; set; }
    public ushort Field31 { get; set; }
    public ushort Field32 { get; set; }
    public ushort Field33 { get; set; }
    public ushort Field34 { get; set; }
    public ushort Field35 { get; set; }
    public ushort Field36 { get; set; }
    public ushort Field37 { get; set; }
    public ushort Field38 { get; set; }
    public ushort Field39 { get; set; }
    public ushort Field40 { get; set; }
    public ushort Field41 { get; set; }
    public ushort Field42 { get; set; }
    public ushort Field43 { get; set; }
    public ushort Field44 { get; set; }
    public ushort Field45 { get; set; }
    public ushort Field46 { get; set; }
    public ushort Field47 { get; set; }
    public string Field48 { get; set; } = string.Empty;
    public string Field49 { get; set; } = string.Empty;
    public string Field50 { get; set; } = string.Empty;
    public string Field51 { get; set; } = string.Empty;

    public DailymazePortalEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadUInt16();
        Field21 = reader.ReadUInt16();
        Field22 = reader.ReadUInt16();
        Field23 = reader.ReadUInt16();
        Field24 = reader.ReadUInt16();
        Field25 = reader.ReadUInt16();
        Field26 = reader.ReadUInt16();
        Field27 = reader.ReadUInt16();
        Field28 = reader.ReadUInt16();
        Field29 = reader.ReadUInt16();
        Field30 = reader.ReadUInt16();
        Field31 = reader.ReadUInt16();
        Field32 = reader.ReadUInt16();
        Field33 = reader.ReadUInt16();
        Field34 = reader.ReadUInt16();
        Field35 = reader.ReadUInt16();
        Field36 = reader.ReadUInt16();
        Field37 = reader.ReadUInt16();
        Field38 = reader.ReadUInt16();
        Field39 = reader.ReadUInt16();
        Field40 = reader.ReadUInt16();
        Field41 = reader.ReadUInt16();
        Field42 = reader.ReadUInt16();
        Field43 = reader.ReadUInt16();
        Field44 = reader.ReadUInt16();
        Field45 = reader.ReadUInt16();
        Field46 = reader.ReadUInt16();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadUTF16UnicodeString();
        Field49 = reader.ReadUTF16UnicodeString();
        Field50 = reader.ReadUTF16UnicodeString();
        Field51 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<DailymazePortalEntry>.TableName => TableName;

    static DailymazePortalEntry IEntry<DailymazePortalEntry>.CreateInstance(BinaryReader reader)
    {
        return new DailymazePortalEntry(reader);
    }
}
