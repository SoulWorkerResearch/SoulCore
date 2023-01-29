global using MazerewardGolddirectKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazerewardGolddirectEntry : IEntry<MazerewardGolddirectEntry>
{
    public const string TableName = "tb_MazeReward_GoldDirect";

    public MazerewardGolddirectKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;
    public string Field7 { get; set; } = string.Empty;

    public MazerewardGolddirectEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<MazerewardGolddirectEntry>.TableName => TableName;

    static MazerewardGolddirectEntry IEntry<MazerewardGolddirectEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazerewardGolddirectEntry(reader);
    }
}
