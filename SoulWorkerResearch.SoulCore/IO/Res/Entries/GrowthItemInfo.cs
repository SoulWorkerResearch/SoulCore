global using GrowthItemInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GrowthItemInfoEntry : IEntry<GrowthItemInfoEntry>
{
    public const string TableName = "tb_Growth_Item_Info";

    public GrowthItemInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public float Field7 { get; set; }
    public float Field8 { get; set; }
    public float Field9 { get; set; }
    public float Field10 { get; set; }
    public float Field11 { get; set; }
    public float Field12 { get; set; }
    public float Field13 { get; set; }
    public float Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public uint Field17 { get; set; }

    public GrowthItemInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadSingle();
        Field8 = reader.ReadSingle();
        Field9 = reader.ReadSingle();
        Field10 = reader.ReadSingle();
        Field11 = reader.ReadSingle();
        Field12 = reader.ReadSingle();
        Field13 = reader.ReadSingle();
        Field14 = reader.ReadSingle();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt32();
    }

    static string IEntry<GrowthItemInfoEntry>.TableName => TableName;

    static GrowthItemInfoEntry IEntry<GrowthItemInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new GrowthItemInfoEntry(reader);
    }
}
