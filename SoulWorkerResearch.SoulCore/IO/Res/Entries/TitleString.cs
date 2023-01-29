global using TitleStringKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class TitleStringEntry : IEntry<TitleStringEntry>
{
    public const string TableName = "tb_Title_String";

    public TitleStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;

    public TitleStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<TitleStringEntry>.TableName => TableName;

    static TitleStringEntry IEntry<TitleStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new TitleStringEntry(reader);
    }
}
