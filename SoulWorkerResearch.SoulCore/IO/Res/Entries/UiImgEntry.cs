global using UiImgKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class UiImgEntry : IEntry<UiImgEntry>
{
    public const string TableName = "tb_UI_Img";

    public UiImgKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public UiImgEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<UiImgEntry>.TableName => TableName;

    static UiImgEntry IEntry<UiImgEntry>.CreateInstance(BinaryReader reader)
    {
        return new UiImgEntry(reader);
    }
}
