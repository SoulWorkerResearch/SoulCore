global using ChattingcommandKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ChattingcommandEntry : IEntry<ChattingcommandEntry>
{
    public const string TableName = "tb_ChattingCommand";

    public ChattingcommandKeyType Id { get; set; }
    public sbyte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;
    public uint Field7 { get; set; }

    public ChattingcommandEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadSByte();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUInt32();
    }

    static string IEntry<ChattingcommandEntry>.TableName => TableName;

    static ChattingcommandEntry IEntry<ChattingcommandEntry>.CreateInstance(BinaryReader reader)
    {
        return new ChattingcommandEntry(reader);
    }
}
