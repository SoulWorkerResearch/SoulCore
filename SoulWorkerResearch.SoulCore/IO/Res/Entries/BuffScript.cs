global using BuffScriptKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BuffScriptEntry : IEntry<BuffScriptEntry>
{
    public const string TableName = "tb_Buff_Script";

    public BuffScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;

    public BuffScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<BuffScriptEntry>.TableName => TableName;

    static BuffScriptEntry IEntry<BuffScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new BuffScriptEntry(reader);
    }
}
