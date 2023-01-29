global using GestureKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GestureEntry : IEntry<GestureEntry>
{
    public const string TableName = "tb_Gesture";

    public GestureKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public ushort Field5 { get; set; }
    public uint Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;
    public byte Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;
    public string Field15 { get; set; } = string.Empty;
    public uint Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }

    public GestureEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
        Field15 = reader.ReadUTF16UnicodeString();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
    }

    static string IEntry<GestureEntry>.TableName => TableName;

    static GestureEntry IEntry<GestureEntry>.CreateInstance(BinaryReader reader)
    {
        return new GestureEntry(reader);
    }
}
