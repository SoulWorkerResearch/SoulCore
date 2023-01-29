global using SpeechbubbleKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SpeechbubbleEntry : IEntry<SpeechbubbleEntry>
{
    public const string TableName = "tb_Speechbubble";

    public SpeechbubbleKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;

    public SpeechbubbleEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SpeechbubbleEntry>.TableName => TableName;

    static SpeechbubbleEntry IEntry<SpeechbubbleEntry>.CreateInstance(BinaryReader reader)
    {
        return new SpeechbubbleEntry(reader);
    }
}
