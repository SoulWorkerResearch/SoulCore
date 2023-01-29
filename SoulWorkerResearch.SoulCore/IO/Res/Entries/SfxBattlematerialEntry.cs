global using SfxBattlematerialKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SfxBattlematerialEntry : IEntry<SfxBattlematerialEntry>
{
    public const string TableName = "tb_SFX_BattleMaterial";

    public SfxBattlematerialKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public SfxBattlematerialEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SfxBattlematerialEntry>.TableName => TableName;

    static SfxBattlematerialEntry IEntry<SfxBattlematerialEntry>.CreateInstance(BinaryReader reader)
    {
        return new SfxBattlematerialEntry(reader);
    }
}
