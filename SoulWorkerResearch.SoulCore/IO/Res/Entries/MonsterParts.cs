global using MonsterPartsKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MonsterPartsEntry : IEntry<MonsterPartsEntry>
{
    public const string TableName = "tb_Monster_Parts";

    public MonsterPartsKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;

    public MonsterPartsEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<MonsterPartsEntry>.TableName => TableName;

    static MonsterPartsEntry IEntry<MonsterPartsEntry>.CreateInstance(BinaryReader reader)
    {
        return new MonsterPartsEntry(reader);
    }
}
