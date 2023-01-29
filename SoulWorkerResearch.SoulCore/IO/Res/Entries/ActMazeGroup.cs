global using ActMazeGroupKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ActMazeGroupEntry : IEntry<ActMazeGroupEntry>
{
    public const string TableName = "tb_Act_Maze_Group";

    public ActMazeGroupKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public int Field4 { get; set; }
    public int Field5 { get; set; }
    public byte Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public ushort Field9 { get; set; }

    public ActMazeGroupEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadInt32();
        Field5 = reader.ReadInt32();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt16();
    }

    static string IEntry<ActMazeGroupEntry>.TableName => TableName;

    static ActMazeGroupEntry IEntry<ActMazeGroupEntry>.CreateInstance(BinaryReader reader)
    {
        return new ActMazeGroupEntry(reader);
    }
}
