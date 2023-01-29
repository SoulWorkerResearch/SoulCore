global using NpcPartsKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class NpcPartsEntry : IEntry<NpcPartsEntry>
{
    public const string TableName = "tb_NPC_Parts";

    public NpcPartsKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;

    public NpcPartsEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<NpcPartsEntry>.TableName => TableName;

    static NpcPartsEntry IEntry<NpcPartsEntry>.CreateInstance(BinaryReader reader)
    {
        return new NpcPartsEntry(reader);
    }
}
