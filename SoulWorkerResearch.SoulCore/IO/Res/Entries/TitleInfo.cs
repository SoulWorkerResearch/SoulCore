global using TitleInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class TitleInfoEntry : IEntry<TitleInfoEntry>
{
    public const string TableName = "tb_Title_Info";

    public TitleInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public byte Field5 { get; set; }
    public uint Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public ushort Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public float Field18 { get; set; }
    public float Field19 { get; set; }
    public float Field20 { get; set; }
    public float Field21 { get; set; }
    public float Field22 { get; set; }

    public TitleInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadSingle();
        Field19 = reader.ReadSingle();
        Field20 = reader.ReadSingle();
        Field21 = reader.ReadSingle();
        Field22 = reader.ReadSingle();
    }

    static string IEntry<TitleInfoEntry>.TableName => TableName;

    static TitleInfoEntry IEntry<TitleInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new TitleInfoEntry(reader);
    }
}
