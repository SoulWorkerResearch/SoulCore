global using AchievementScriptKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AchievementScriptEntry : IEntry<AchievementScriptEntry>
{
    public const string TableName = "tb_Achievement_Script";

    public AchievementScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;

    public AchievementScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<AchievementScriptEntry>.TableName => TableName;

    static AchievementScriptEntry IEntry<AchievementScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new AchievementScriptEntry(reader);
    }
}
