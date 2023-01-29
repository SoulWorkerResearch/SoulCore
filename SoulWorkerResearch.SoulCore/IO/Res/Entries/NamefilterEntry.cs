global using NamefilterKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class NamefilterEntry : IEntry<NamefilterEntry>
{
    public const string TableName = "tb_NameFilter";

    public NamefilterKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;

    public NamefilterEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<NamefilterEntry>.TableName => TableName;

    static NamefilterEntry IEntry<NamefilterEntry>.CreateInstance(BinaryReader reader)
    {
        return new NamefilterEntry(reader);
    }
}
