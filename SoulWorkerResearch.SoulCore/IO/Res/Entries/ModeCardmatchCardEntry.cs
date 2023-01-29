global using ModeCardmatchCardKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeCardmatchCardEntry : IEntry<ModeCardmatchCardEntry>
{
    public const string TableName = "tb_Mode_CardMatch_Card";

    public ModeCardmatchCardKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;

    public ModeCardmatchCardEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<ModeCardmatchCardEntry>.TableName => TableName;

    static ModeCardmatchCardEntry IEntry<ModeCardmatchCardEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeCardmatchCardEntry(reader);
    }
}
