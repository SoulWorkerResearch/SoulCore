global using SkillOptionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SkillOptionEntry : IEntry<SkillOptionEntry>
{
    public const string TableName = "tb_Skill_Option";

    public SkillOptionKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public short Field2 { get; set; }
    public short Field3 { get; set; }

    public SkillOptionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadInt16();
        Field3 = reader.ReadInt16();
    }

    static string IEntry<SkillOptionEntry>.TableName => TableName;

    static SkillOptionEntry IEntry<SkillOptionEntry>.CreateInstance(BinaryReader reader)
    {
        return new SkillOptionEntry(reader);
    }
}
