global using CutsceneStringKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CutsceneStringEntry : IEntry<CutsceneStringEntry>
{
    public const string TableName = "tb_Cutscene_String";

    public CutsceneStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public CutsceneStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CutsceneStringEntry>.TableName => TableName;

    static CutsceneStringEntry IEntry<CutsceneStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new CutsceneStringEntry(reader);
    }
}
