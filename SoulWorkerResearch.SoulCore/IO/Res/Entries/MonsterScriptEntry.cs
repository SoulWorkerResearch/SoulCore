global using MonsterScriptKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MonsterScriptEntry : IEntry<MonsterScriptEntry>
{
    public const string TableName = "tb_Monster_script";

    public MonsterScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public MonsterScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<MonsterScriptEntry>.TableName => TableName;

    static MonsterScriptEntry IEntry<MonsterScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new MonsterScriptEntry(reader);
    }
}
