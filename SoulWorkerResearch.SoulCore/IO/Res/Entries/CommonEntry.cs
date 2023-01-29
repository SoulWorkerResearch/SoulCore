global using CommonKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CommonEntry : IEntry<CommonEntry>
{
    public const string TableName = "tb_Common";

    public CommonKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public float Field2 { get; set; }

    public CommonEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadSingle();
    }

    static string IEntry<CommonEntry>.TableName => TableName;

    static CommonEntry IEntry<CommonEntry>.CreateInstance(BinaryReader reader)
    {
        return new CommonEntry(reader);
    }
}
