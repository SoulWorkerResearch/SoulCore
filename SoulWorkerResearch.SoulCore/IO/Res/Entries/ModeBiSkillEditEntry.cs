global using ModeBiSkillEditKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeBiSkillEditEntry : IEntry<ModeBiSkillEditEntry>
{
    public const string TableName = "tb_Mode_BI_Skill_Edit";

    public ModeBiSkillEditKeyType Id { get; set; }
    public uint Field1 { get; set; }

    public ModeBiSkillEditEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
    }

    static string IEntry<ModeBiSkillEditEntry>.TableName => TableName;

    static ModeBiSkillEditEntry IEntry<ModeBiSkillEditEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeBiSkillEditEntry(reader);
    }
}
