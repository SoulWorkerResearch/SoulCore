global using AkashicPartsKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AkashicPartsEntry : IEntry<AkashicPartsEntry>
{
    public const string TableName = "tb_Akashic_Parts";

    public AkashicPartsKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;

    public AkashicPartsEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<AkashicPartsEntry>.TableName => TableName;

    static AkashicPartsEntry IEntry<AkashicPartsEntry>.CreateInstance(BinaryReader reader)
    {
        return new AkashicPartsEntry(reader);
    }
}
