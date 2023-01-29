global using TalkStringKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class TalkStringEntry : IEntry<TalkStringEntry>
{
    public const string TableName = "tb_Talk_String";

    public TalkStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public TalkStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<TalkStringEntry>.TableName => TableName;

    static TalkStringEntry IEntry<TalkStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new TalkStringEntry(reader);
    }
}
