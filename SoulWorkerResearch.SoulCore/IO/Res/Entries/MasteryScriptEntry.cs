global using MasteryScriptKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MasteryScriptEntry : IEntry<MasteryScriptEntry>
{
    public const string TableName = "tb_Mastery_Script";

    public MasteryScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;

    public MasteryScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<MasteryScriptEntry>.TableName => TableName;

    static MasteryScriptEntry IEntry<MasteryScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new MasteryScriptEntry(reader);
    }
}
