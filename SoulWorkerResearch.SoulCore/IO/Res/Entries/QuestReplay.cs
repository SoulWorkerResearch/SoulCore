global using QuestReplayKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class QuestReplayEntry : IEntry<QuestReplayEntry>
{
    public const string TableName = "tb_Quest_Replay";

    public QuestReplayKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public uint Field4 { get; set; }
    public ushort Field5 { get; set; }
    public byte Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public string Field9 { get; set; } = string.Empty;
    public uint Field10 { get; set; }

    public QuestReplayEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUInt32();
    }

    static string IEntry<QuestReplayEntry>.TableName => TableName;

    static QuestReplayEntry IEntry<QuestReplayEntry>.CreateInstance(BinaryReader reader)
    {
        return new QuestReplayEntry(reader);
    }
}
