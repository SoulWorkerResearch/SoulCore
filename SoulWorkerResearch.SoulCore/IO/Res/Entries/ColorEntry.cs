global using ColorKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ColorEntry : IEntry<ColorEntry>
{
    public const string TableName = "tb_Color";

    public ColorKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public byte Field14 { get; set; }
    public byte Field15 { get; set; }
    public byte Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }

    public ColorEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
    }

    static string IEntry<ColorEntry>.TableName => TableName;

    static ColorEntry IEntry<ColorEntry>.CreateInstance(BinaryReader reader)
    {
        return new ColorEntry(reader);
    }
}
