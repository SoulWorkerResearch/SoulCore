global using ClassbattleRoleKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ClassbattleRoleEntry : IEntry<ClassbattleRoleEntry>
{
    public const string TableName = "tb_ClassBattle_Role";

    public ClassbattleRoleKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public byte Field10 { get; set; }

    public ClassbattleRoleEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadByte();
    }

    static string IEntry<ClassbattleRoleEntry>.TableName => TableName;

    static ClassbattleRoleEntry IEntry<ClassbattleRoleEntry>.CreateInstance(BinaryReader reader)
    {
        return new ClassbattleRoleEntry(reader);
    }
}
