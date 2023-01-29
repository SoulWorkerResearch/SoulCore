global using BuffKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BuffEntry : IEntry<BuffEntry>
{
    public const string TableName = "tb_Buff";

    public BuffKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public int Field6 { get; set; }
    public byte Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public string Field14 { get; set; } = string.Empty;
    public ushort Field15 { get; set; }
    public uint Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public ushort Field19 { get; set; }
    public ushort Field20 { get; set; }
    public int Field21 { get; set; }
    public ushort Field22 { get; set; }
    public int Field23 { get; set; }
    public ushort Field24 { get; set; }
    public int Field25 { get; set; }
    public ushort Field26 { get; set; }
    public ushort Field27 { get; set; }
    public ushort Field28 { get; set; }
    public ushort Field29 { get; set; }
    public ushort Field30 { get; set; }
    public ushort Field31 { get; set; }
    public string Field32 { get; set; } = string.Empty;
    public ushort Field33 { get; set; }
    public uint Field34 { get; set; }
    public byte Field35 { get; set; }
    public byte Field36 { get; set; }

    public BuffEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadInt32();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadUTF16UnicodeString();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadUInt16();
        Field21 = reader.ReadInt32();
        Field22 = reader.ReadUInt16();
        Field23 = reader.ReadInt32();
        Field24 = reader.ReadUInt16();
        Field25 = reader.ReadInt32();
        Field26 = reader.ReadUInt16();
        Field27 = reader.ReadUInt16();
        Field28 = reader.ReadUInt16();
        Field29 = reader.ReadUInt16();
        Field30 = reader.ReadUInt16();
        Field31 = reader.ReadUInt16();
        Field32 = reader.ReadUTF16UnicodeString();
        Field33 = reader.ReadUInt16();
        Field34 = reader.ReadUInt32();
        Field35 = reader.ReadByte();
        Field36 = reader.ReadByte();
    }

    static string IEntry<BuffEntry>.TableName => TableName;

    static BuffEntry IEntry<BuffEntry>.CreateInstance(BinaryReader reader)
    {
        return new BuffEntry(reader);
    }
}
