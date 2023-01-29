global using ChapterGroupKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ChapterGroupEntry : IEntry<ChapterGroupEntry>
{
    public const string TableName = "tb_Chapter_Group";

    public ChapterGroupKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public int Field5 { get; set; }
    public int Field6 { get; set; }
    public byte Field7 { get; set; }
    public uint Field8 { get; set; }
    public ushort Field9 { get; set; }
    public byte Field10 { get; set; }
    public string Field11 { get; set; } = string.Empty;

    public ChapterGroupEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadInt32();
        Field6 = reader.ReadInt32();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<ChapterGroupEntry>.TableName => TableName;

    static ChapterGroupEntry IEntry<ChapterGroupEntry>.CreateInstance(BinaryReader reader)
    {
        return new ChapterGroupEntry(reader);
    }
}
