global using NpcScriptKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class NpcScriptEntry : IEntry<NpcScriptEntry>
{
    public const string TableName = "tb_NPC_Script";

    public NpcScriptKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public NpcScriptEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<NpcScriptEntry>.TableName => TableName;

    static NpcScriptEntry IEntry<NpcScriptEntry>.CreateInstance(BinaryReader reader)
    {
        return new NpcScriptEntry(reader);
    }
}
