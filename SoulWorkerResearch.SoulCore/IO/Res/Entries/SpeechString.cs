global using SpeechStringKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SpeechStringEntry : IEntry<SpeechStringEntry>
{
    public const string TableName = "tb_Speech_String";

    public SpeechStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public SpeechStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SpeechStringEntry>.TableName => TableName;

    static SpeechStringEntry IEntry<SpeechStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new SpeechStringEntry(reader);
    }
}
