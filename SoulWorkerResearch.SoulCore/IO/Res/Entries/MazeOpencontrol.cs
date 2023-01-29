global using MazeOpencontrolKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazeOpencontrolEntry : IEntry<MazeOpencontrolEntry>
{
    public const string TableName = "tb_Maze_OpenControl";

    public MazeOpencontrolKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;

    public MazeOpencontrolEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<MazeOpencontrolEntry>.TableName => TableName;

    static MazeOpencontrolEntry IEntry<MazeOpencontrolEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazeOpencontrolEntry(reader);
    }
}
