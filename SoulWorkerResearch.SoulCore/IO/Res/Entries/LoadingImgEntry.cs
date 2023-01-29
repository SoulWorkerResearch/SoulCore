global using LoadingImgKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LoadingImgEntry : IEntry<LoadingImgEntry>
{
    public const string TableName = "tb_Loading_Img";

    public LoadingImgKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;

    public LoadingImgEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<LoadingImgEntry>.TableName => TableName;

    static LoadingImgEntry IEntry<LoadingImgEntry>.CreateInstance(BinaryReader reader)
    {
        return new LoadingImgEntry(reader);
    }
}
