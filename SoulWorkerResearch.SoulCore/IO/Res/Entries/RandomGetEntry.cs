global using RandomGetKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RandomGetEntry : IEntry<RandomGetEntry>
{
    public const string TableName = "tb_Random_Get";

    public RandomGetKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public uint Field17 { get; set; }
    public uint Field18 { get; set; }
    public uint Field19 { get; set; }
    public uint Field20 { get; set; }
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public uint Field27 { get; set; }
    public uint Field28 { get; set; }
    public uint Field29 { get; set; }
    public uint Field30 { get; set; }
    public byte Field31 { get; set; }
    public byte Field32 { get; set; }
    public byte Field33 { get; set; }
    public byte Field34 { get; set; }
    public byte Field35 { get; set; }
    public byte Field36 { get; set; }
    public byte Field37 { get; set; }
    public byte Field38 { get; set; }
    public byte Field39 { get; set; }
    public byte Field40 { get; set; }
    public byte Field41 { get; set; }
    public byte Field42 { get; set; }
    public byte Field43 { get; set; }
    public byte Field44 { get; set; }
    public byte Field45 { get; set; }
    public byte Field46 { get; set; }
    public byte Field47 { get; set; }
    public byte Field48 { get; set; }
    public byte Field49 { get; set; }
    public byte Field50 { get; set; }
    public byte Field51 { get; set; }
    public byte Field52 { get; set; }
    public byte Field53 { get; set; }
    public byte Field54 { get; set; }
    public byte Field55 { get; set; }
    public byte Field56 { get; set; }
    public byte Field57 { get; set; }
    public byte Field58 { get; set; }
    public byte Field59 { get; set; }
    public byte Field60 { get; set; }

    public RandomGetEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadUInt32();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadUInt32();
        Field28 = reader.ReadUInt32();
        Field29 = reader.ReadUInt32();
        Field30 = reader.ReadUInt32();
        Field31 = reader.ReadByte();
        Field32 = reader.ReadByte();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadByte();
        Field35 = reader.ReadByte();
        Field36 = reader.ReadByte();
        Field37 = reader.ReadByte();
        Field38 = reader.ReadByte();
        Field39 = reader.ReadByte();
        Field40 = reader.ReadByte();
        Field41 = reader.ReadByte();
        Field42 = reader.ReadByte();
        Field43 = reader.ReadByte();
        Field44 = reader.ReadByte();
        Field45 = reader.ReadByte();
        Field46 = reader.ReadByte();
        Field47 = reader.ReadByte();
        Field48 = reader.ReadByte();
        Field49 = reader.ReadByte();
        Field50 = reader.ReadByte();
        Field51 = reader.ReadByte();
        Field52 = reader.ReadByte();
        Field53 = reader.ReadByte();
        Field54 = reader.ReadByte();
        Field55 = reader.ReadByte();
        Field56 = reader.ReadByte();
        Field57 = reader.ReadByte();
        Field58 = reader.ReadByte();
        Field59 = reader.ReadByte();
        Field60 = reader.ReadByte();
    }

    static string IEntry<RandomGetEntry>.TableName => TableName;

    static RandomGetEntry IEntry<RandomGetEntry>.CreateInstance(BinaryReader reader)
    {
        return new RandomGetEntry(reader);
    }
}
