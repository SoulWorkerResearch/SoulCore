global using VfxBattlematerialKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class VfxBattlematerialEntry : IEntry<VfxBattlematerialEntry>
{
    public const string TableName = "tb_VFX_BattleMaterial";

    public VfxBattlematerialKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;

    public VfxBattlematerialEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<VfxBattlematerialEntry>.TableName => TableName;

    static VfxBattlematerialEntry IEntry<VfxBattlematerialEntry>.CreateInstance(BinaryReader reader)
    {
        return new VfxBattlematerialEntry(reader);
    }
}
