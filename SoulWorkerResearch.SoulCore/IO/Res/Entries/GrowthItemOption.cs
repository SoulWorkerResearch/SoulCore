global using GrowthItemOptionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GrowthItemOptionEntry : IEntry<GrowthItemOptionEntry>
{
    public const string TableName = "tb_Growth_Item_Option";

    public GrowthItemOptionKeyType Id { get; set; }
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
    public byte Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public uint Field27 { get; set; }
    public uint Field28 { get; set; }
    public uint Field29 { get; set; }
    public uint Field30 { get; set; }
    public uint Field31 { get; set; }
    public uint Field32 { get; set; }
    public uint Field33 { get; set; }
    public uint Field34 { get; set; }
    public uint Field35 { get; set; }
    public uint Field36 { get; set; }
    public uint Field37 { get; set; }
    public uint Field38 { get; set; }
    public uint Field39 { get; set; }
    public uint Field40 { get; set; }
    public uint Field41 { get; set; }
    public int Field42 { get; set; }
    public int Field43 { get; set; }
    public int Field44 { get; set; }
    public int Field45 { get; set; }
    public int Field46 { get; set; }
    public int Field47 { get; set; }
    public int Field48 { get; set; }
    public int Field49 { get; set; }
    public int Field50 { get; set; }
    public int Field51 { get; set; }
    public int Field52 { get; set; }
    public int Field53 { get; set; }
    public int Field54 { get; set; }
    public int Field55 { get; set; }
    public int Field56 { get; set; }
    public int Field57 { get; set; }
    public int Field58 { get; set; }
    public int Field59 { get; set; }
    public int Field60 { get; set; }
    public int Field61 { get; set; }

    public GrowthItemOptionEntry(BinaryReader reader)
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
        Field21 = reader.ReadByte();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadUInt32();
        Field28 = reader.ReadUInt32();
        Field29 = reader.ReadUInt32();
        Field30 = reader.ReadUInt32();
        Field31 = reader.ReadUInt32();
        Field32 = reader.ReadUInt32();
        Field33 = reader.ReadUInt32();
        Field34 = reader.ReadUInt32();
        Field35 = reader.ReadUInt32();
        Field36 = reader.ReadUInt32();
        Field37 = reader.ReadUInt32();
        Field38 = reader.ReadUInt32();
        Field39 = reader.ReadUInt32();
        Field40 = reader.ReadUInt32();
        Field41 = reader.ReadUInt32();
        Field42 = reader.ReadInt32();
        Field43 = reader.ReadInt32();
        Field44 = reader.ReadInt32();
        Field45 = reader.ReadInt32();
        Field46 = reader.ReadInt32();
        Field47 = reader.ReadInt32();
        Field48 = reader.ReadInt32();
        Field49 = reader.ReadInt32();
        Field50 = reader.ReadInt32();
        Field51 = reader.ReadInt32();
        Field52 = reader.ReadInt32();
        Field53 = reader.ReadInt32();
        Field54 = reader.ReadInt32();
        Field55 = reader.ReadInt32();
        Field56 = reader.ReadInt32();
        Field57 = reader.ReadInt32();
        Field58 = reader.ReadInt32();
        Field59 = reader.ReadInt32();
        Field60 = reader.ReadInt32();
        Field61 = reader.ReadInt32();
    }

    static string IEntry<GrowthItemOptionEntry>.TableName => TableName;

    static GrowthItemOptionEntry IEntry<GrowthItemOptionEntry>.CreateInstance(BinaryReader reader)
    {
        return new GrowthItemOptionEntry(reader);
    }
}
