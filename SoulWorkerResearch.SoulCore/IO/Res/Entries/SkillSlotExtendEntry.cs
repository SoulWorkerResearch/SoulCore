global using SkillSlotExtendKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SkillSlotExtendEntry : IEntry<SkillSlotExtendEntry>
{
    public const string TableName = "tb_Skill_Slot_Extend";

    public SkillSlotExtendKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }

    public SkillSlotExtendEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
    }

    static string IEntry<SkillSlotExtendEntry>.TableName => TableName;

    static SkillSlotExtendEntry IEntry<SkillSlotExtendEntry>.CreateInstance(BinaryReader reader)
    {
        return new SkillSlotExtendEntry(reader);
    }
}
