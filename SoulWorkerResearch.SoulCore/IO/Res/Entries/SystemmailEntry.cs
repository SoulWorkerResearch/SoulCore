global using SystemmailKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SystemmailEntry : IEntry<SystemmailEntry>
{
    public const string TableName = "tb_SystemMail";

    public SystemmailKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;

    public SystemmailEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SystemmailEntry>.TableName => TableName;

    static SystemmailEntry IEntry<SystemmailEntry>.CreateInstance(BinaryReader reader)
    {
        return new SystemmailEntry(reader);
    }
}
