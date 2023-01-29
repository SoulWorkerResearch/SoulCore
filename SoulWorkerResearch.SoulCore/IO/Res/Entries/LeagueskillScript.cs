global using LeagueskillScriptKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LeagueskillScriptEntry : IEntry<LeagueskillScriptEntry>
{
    public const string TableName = "tb_LeagueSkill_Script";

    public LeagueskillScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;

    public LeagueskillScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<LeagueskillScriptEntry>.TableName => TableName;

    static LeagueskillScriptEntry IEntry<LeagueskillScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new LeagueskillScriptEntry(reader);
    }
}
