global using SoulMetryStringKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SoulMetryStringEntry : IEntry<SoulMetryStringEntry>
{
    public const string TableName = "tb_soul_metry_string";

    public SoulMetryStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public SoulMetryStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SoulMetryStringEntry>.TableName => TableName;

    static SoulMetryStringEntry IEntry<SoulMetryStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new SoulMetryStringEntry(reader);
    }
}
