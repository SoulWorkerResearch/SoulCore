global using SkillScriptKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SkillScriptEntry : IEntry<SkillScriptEntry>
{
    public const string TableName = "tb_Skill_Script";

    public SkillScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;

    public SkillScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SkillScriptEntry>.TableName => TableName;

    static SkillScriptEntry IEntry<SkillScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new SkillScriptEntry(reader);
    }
}
