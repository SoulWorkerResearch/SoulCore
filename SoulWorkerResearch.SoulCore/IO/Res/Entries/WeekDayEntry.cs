global using WeekDayKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class WeekDayEntry : IEntry<WeekDayEntry>
{
    public const string TableName = "tb_Week_Day";

    public WeekDayKeyType Id { get; set; }
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

    public WeekDayEntry(BinaryReader reader)
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
    }

    static string IEntry<WeekDayEntry>.TableName => TableName;

    static WeekDayEntry IEntry<WeekDayEntry>.CreateInstance(BinaryReader reader)
    {
        return new WeekDayEntry(reader);
    }
}
