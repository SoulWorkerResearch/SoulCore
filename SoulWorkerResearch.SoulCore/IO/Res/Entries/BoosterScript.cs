global using BoosterScriptKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BoosterScriptEntry : IEntry<BoosterScriptEntry>
{
    public const string TableName = "tb_Booster_Script";

    public BoosterScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;

    public BoosterScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<BoosterScriptEntry>.TableName => TableName;

    static BoosterScriptEntry IEntry<BoosterScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new BoosterScriptEntry(reader);
    }
}
