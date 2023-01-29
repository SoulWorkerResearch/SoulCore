global using ChattingfilterKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ChattingfilterEntry : IEntry<ChattingfilterEntry>
{
    public const string TableName = "tb_ChattingFilter";

    public ChattingfilterKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public ChattingfilterEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<ChattingfilterEntry>.TableName => TableName;

    static ChattingfilterEntry IEntry<ChattingfilterEntry>.CreateInstance(BinaryReader reader)
    {
        return new ChattingfilterEntry(reader);
    }
}
