global using UiStringKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class UiStringEntry : IEntry<UiStringEntry>
{
    public const string TableName = "tb_UI_String";

    public UiStringKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;

    public UiStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<UiStringEntry>.TableName => TableName;

    static UiStringEntry IEntry<UiStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new UiStringEntry(reader);
    }
}
