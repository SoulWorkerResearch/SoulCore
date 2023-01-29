global using SfxGroundmaterialKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SfxGroundmaterialEntry : IEntry<SfxGroundmaterialEntry>
{
    public const string TableName = "tb_SFX_GroundMaterial";

    public SfxGroundmaterialKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public float Field2 { get; set; }

    public SfxGroundmaterialEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadSingle();
    }

    static string IEntry<SfxGroundmaterialEntry>.TableName => TableName;

    static SfxGroundmaterialEntry IEntry<SfxGroundmaterialEntry>.CreateInstance(BinaryReader reader)
    {
        return new SfxGroundmaterialEntry(reader);
    }
}
