global using MazeInfoKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MazeInfoEntry : IEntry<MazeInfoEntry>
{
    public const string TableName = "tb_Maze_Info";

    public MazeInfoKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public byte Field14 { get; set; }
    public uint Field15 { get; set; }
    public byte Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }
    public uint Field21 { get; set; }
    public ushort Field22 { get; set; }
    public ushort Field23 { get; set; }
    public ushort Field24 { get; set; }
    public string Field25 { get; set; } = string.Empty;
    public string Field26 { get; set; } = string.Empty;
    public string Field27 { get; set; } = string.Empty;
    public string Field28 { get; set; } = string.Empty;
    public string Field29 { get; set; } = string.Empty;
    public string Field30 { get; set; } = string.Empty;
    public ushort Field31 { get; set; }
    public ushort Field32 { get; set; }
    public byte Field33 { get; set; }
    public ushort Field34 { get; set; }
    public string Field35 { get; set; } = string.Empty;
    public string Field36 { get; set; } = string.Empty;
    public ushort Field37 { get; set; }
    public ushort Field38 { get; set; }
    public uint Field39 { get; set; }
    public uint Field40 { get; set; }
    public short Field41 { get; set; }
    public uint Field42 { get; set; }
    public uint Field43 { get; set; }
    public uint Field44 { get; set; }
    public uint Field45 { get; set; }
    public uint Field46 { get; set; }
    public byte Field47 { get; set; }
    public byte Field48 { get; set; }
    public string Field49 { get; set; } = string.Empty;
    public byte Field50 { get; set; }
    public uint Field51 { get; set; }
    public byte Field52 { get; set; }
    public byte Field53 { get; set; }
    public byte Field54 { get; set; }
    public uint Field55 { get; set; }
    public byte Field56 { get; set; }

    public MazeInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt16();
        Field23 = reader.ReadUInt16();
        Field24 = reader.ReadUInt16();
        Field25 = reader.ReadUTF16UnicodeString();
        Field26 = reader.ReadUTF16UnicodeString();
        Field27 = reader.ReadUTF16UnicodeString();
        Field28 = reader.ReadUTF16UnicodeString();
        Field29 = reader.ReadUTF16UnicodeString();
        Field30 = reader.ReadUTF16UnicodeString();
        Field31 = reader.ReadUInt16();
        Field32 = reader.ReadUInt16();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadUInt16();
        Field35 = reader.ReadUTF16UnicodeString();
        Field36 = reader.ReadUTF16UnicodeString();
        Field37 = reader.ReadUInt16();
        Field38 = reader.ReadUInt16();
        Field39 = reader.ReadUInt32();
        Field40 = reader.ReadUInt32();
        Field41 = reader.ReadInt16();
        Field42 = reader.ReadUInt32();
        Field43 = reader.ReadUInt32();
        Field44 = reader.ReadUInt32();
        Field45 = reader.ReadUInt32();
        Field46 = reader.ReadUInt32();
        Field47 = reader.ReadByte();
        Field48 = reader.ReadByte();
        Field49 = reader.ReadUTF16UnicodeString();
        Field50 = reader.ReadByte();
        Field51 = reader.ReadUInt32();
        Field52 = reader.ReadByte();
        Field53 = reader.ReadByte();
        Field54 = reader.ReadByte();
        Field55 = reader.ReadUInt32();
        Field56 = reader.ReadByte();
    }

    static string IEntry<MazeInfoEntry>.TableName => TableName;

    static MazeInfoEntry IEntry<MazeInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new MazeInfoEntry(reader);
    }
}
