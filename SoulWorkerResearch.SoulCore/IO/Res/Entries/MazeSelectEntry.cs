global using MazeSelectKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazeSelectEntry : IEntry<MazeSelectEntry>
{
    public const string TableName = "tb_Maze_Select";

    public MazeSelectKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public ushort Field10 { get; set; }
    public ushort Field11 { get; set; }
    public ushort Field12 { get; set; }
    public ushort Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }

    public MazeSelectEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
    }

    static string IEntry<MazeSelectEntry>.TableName => TableName;

    static MazeSelectEntry IEntry<MazeSelectEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazeSelectEntry(reader);
    }
}
