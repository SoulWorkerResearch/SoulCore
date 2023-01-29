global using SkillDivideKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SkillDivideEntry : IEntry<SkillDivideEntry>
{
    public const string TableName = "tb_Skill_Divide";

    public SkillDivideKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }

    public SkillDivideEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
    }

    static string IEntry<SkillDivideEntry>.TableName => TableName;

    static SkillDivideEntry IEntry<SkillDivideEntry>.CreateInstance(BinaryReader reader)
    {
        return new SkillDivideEntry(reader);
    }
}
