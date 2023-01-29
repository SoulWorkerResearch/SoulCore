global using MasteryKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MasteryEntry : IEntry<MasteryEntry>
{
    public const string TableName = "tb_Mastery";

    public MasteryKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public sbyte Field2 { get; set; }
    public short Field3 { get; set; }
    public sbyte Field4 { get; set; }
    public short Field5 { get; set; }
    public sbyte Field6 { get; set; }
    public sbyte Field7 { get; set; }
    public sbyte Field8 { get; set; }
    public sbyte Field9 { get; set; }
    public sbyte Field10 { get; set; }
    public sbyte Field11 { get; set; }
    public uint Field12 { get; set; }
    public short Field13 { get; set; }
    public short Field14 { get; set; }
    public short Field15 { get; set; }
    public float Field16 { get; set; }
    public float Field17 { get; set; }
    public float Field18 { get; set; }
    public sbyte Field19 { get; set; }
    public sbyte Field20 { get; set; }
    public sbyte Field21 { get; set; }
    public float Field22 { get; set; }
    public float Field23 { get; set; }
    public float Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public sbyte Field27 { get; set; }
    public short Field28 { get; set; }

    public MasteryEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadSByte();
        Field3 = reader.ReadInt16();
        Field4 = reader.ReadSByte();
        Field5 = reader.ReadInt16();
        Field6 = reader.ReadSByte();
        Field7 = reader.ReadSByte();
        Field8 = reader.ReadSByte();
        Field9 = reader.ReadSByte();
        Field10 = reader.ReadSByte();
        Field11 = reader.ReadSByte();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadInt16();
        Field14 = reader.ReadInt16();
        Field15 = reader.ReadInt16();
        Field16 = reader.ReadSingle();
        Field17 = reader.ReadSingle();
        Field18 = reader.ReadSingle();
        Field19 = reader.ReadSByte();
        Field20 = reader.ReadSByte();
        Field21 = reader.ReadSByte();
        Field22 = reader.ReadSingle();
        Field23 = reader.ReadSingle();
        Field24 = reader.ReadSingle();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadSByte();
        Field28 = reader.ReadInt16();
    }

    static string IEntry<MasteryEntry>.TableName => TableName;

    static MasteryEntry IEntry<MasteryEntry>.CreateInstance(BinaryReader reader)
    {
        return new MasteryEntry(reader);
    }
}
