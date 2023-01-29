global using WeekGroupKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class WeekGroupEntry : IEntry<WeekGroupEntry>
{
    public const string TableName = "tb_Week_Group";

    public WeekGroupKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public ushort Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public uint Field9 { get; set; }
    public ushort Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;

    public WeekGroupEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<WeekGroupEntry>.TableName => TableName;

    static WeekGroupEntry IEntry<WeekGroupEntry>.CreateInstance(BinaryReader reader)
    {
        return new WeekGroupEntry(reader);
    }
}
