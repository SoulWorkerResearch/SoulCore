global using SpeechKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SpeechEntry : IEntry<SpeechEntry>
{
    public const string TableName = "tb_Speech";

    public SpeechKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public string Field14 { get; set; } = string.Empty;
    public string Field15 { get; set; } = string.Empty;

    public SpeechEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUTF16UnicodeString();
        Field15 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SpeechEntry>.TableName => TableName;

    static SpeechEntry IEntry<SpeechEntry>.CreateInstance(BinaryReader reader)
    {
        return new SpeechEntry(reader);
    }
}
