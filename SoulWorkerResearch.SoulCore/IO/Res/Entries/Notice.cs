global using NoticeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class NoticeEntry : IEntry<NoticeEntry>
{
    public const string TableName = "tb_Notice";

    public NoticeKeyType Id { get; set; }
    public sbyte Field1 { get; set; }
    public uint Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;

    public NoticeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadSByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<NoticeEntry>.TableName => TableName;

    static NoticeEntry IEntry<NoticeEntry>.CreateInstance(BinaryReader reader)
    {
        return new NoticeEntry(reader);
    }
}
