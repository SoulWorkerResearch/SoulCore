global using TooltipStringKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class TooltipStringEntry : IEntry<TooltipStringEntry>
{
    public const string TableName = "tb_Tooltip_String";

    public TooltipStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;

    public TooltipStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<TooltipStringEntry>.TableName => TableName;

    static TooltipStringEntry IEntry<TooltipStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new TooltipStringEntry(reader);
    }
}
