global using CinemaStringKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CinemaStringEntry : IEntry<CinemaStringEntry>
{
    public const string TableName = "tb_Cinema_String";

    public CinemaStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;
    public string Field9 { get; set; } = string.Empty;
    public string Field10 { get; set; } = string.Empty;
    public string Field11 { get; set; } = string.Empty;
    public string Field12 { get; set; } = string.Empty;

    public CinemaStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CinemaStringEntry>.TableName => TableName;

    static CinemaStringEntry IEntry<CinemaStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new CinemaStringEntry(reader);
    }
}
