global using MonsterBrokenPartsKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MonsterBrokenPartsEntry : IEntry<MonsterBrokenPartsEntry>
{
    public const string TableName = "tb_Monster_Broken_Parts";

    public MonsterBrokenPartsKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public string Field6 { get; set; } = string.Empty;
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public string Field9 { get; set; } = string.Empty;

    public MonsterBrokenPartsEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<MonsterBrokenPartsEntry>.TableName => TableName;

    static MonsterBrokenPartsEntry IEntry<MonsterBrokenPartsEntry>.CreateInstance(BinaryReader reader)
    {
        return new MonsterBrokenPartsEntry(reader);
    }
}
