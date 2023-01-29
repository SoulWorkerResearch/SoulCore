global using StatusKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class StatusEntry : IEntry<StatusEntry>
{
    public const string TableName = "tb_Status";

    public StatusKeyType Id { get; set; }
    public float Field1 { get; set; }
    public float Field2 { get; set; }
    public float Field3 { get; set; }
    public float Field4 { get; set; }
    public float Field5 { get; set; }
    public float Field6 { get; set; }
    public float Field7 { get; set; }
    public float Field8 { get; set; }
    public float Field9 { get; set; }
    public float Field10 { get; set; }
    public float Field11 { get; set; }
    public float Field12 { get; set; }
    public float Field13 { get; set; }
    public float Field14 { get; set; }
    public float Field15 { get; set; }
    public float Field16 { get; set; }
    public float Field17 { get; set; }
    public float Field18 { get; set; }
    public float Field19 { get; set; }
    public float Field20 { get; set; }
    public float Field21 { get; set; }
    public float Field22 { get; set; }
    public float Field23 { get; set; }
    public float Field24 { get; set; }
    public float Field25 { get; set; }
    public float Field26 { get; set; }
    public float Field27 { get; set; }
    public float Field28 { get; set; }
    public float Field29 { get; set; }
    public float Field30 { get; set; }
    public float Field31 { get; set; }
    public float Field32 { get; set; }
    public float Field33 { get; set; }
    public float Field34 { get; set; }
    public float Field35 { get; set; }
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
    public float Field48 { get; set; }
    public float Field49 { get; set; }
    public float Field50 { get; set; }
    public float Field51 { get; set; }
    public float Field52 { get; set; }
    public float Field53 { get; set; }
    public float Field54 { get; set; }
    public float Field55 { get; set; }
    public float Field56 { get; set; }

    public StatusEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadSingle();
        Field2 = reader.ReadSingle();
        Field3 = reader.ReadSingle();
        Field4 = reader.ReadSingle();
        Field5 = reader.ReadSingle();
        Field6 = reader.ReadSingle();
        Field7 = reader.ReadSingle();
        Field8 = reader.ReadSingle();
        Field9 = reader.ReadSingle();
        Field10 = reader.ReadSingle();
        Field11 = reader.ReadSingle();
        Field12 = reader.ReadSingle();
        Field13 = reader.ReadSingle();
        Field14 = reader.ReadSingle();
        Field15 = reader.ReadSingle();
        Field16 = reader.ReadSingle();
        Field17 = reader.ReadSingle();
        Field18 = reader.ReadSingle();
        Field19 = reader.ReadSingle();
        Field20 = reader.ReadSingle();
        Field21 = reader.ReadSingle();
        Field22 = reader.ReadSingle();
        Field23 = reader.ReadSingle();
        Field24 = reader.ReadSingle();
        Field25 = reader.ReadSingle();
        Field26 = reader.ReadSingle();
        Field27 = reader.ReadSingle();
        Field28 = reader.ReadSingle();
        Field29 = reader.ReadSingle();
        Field30 = reader.ReadSingle();
        Field31 = reader.ReadSingle();
        Field32 = reader.ReadSingle();
        Field33 = reader.ReadSingle();
        Field34 = reader.ReadSingle();
        Field35 = reader.ReadSingle();
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
        Field48 = reader.ReadSingle();
        Field49 = reader.ReadSingle();
        Field50 = reader.ReadSingle();
        Field51 = reader.ReadSingle();
        Field52 = reader.ReadSingle();
        Field53 = reader.ReadSingle();
        Field54 = reader.ReadSingle();
        Field55 = reader.ReadSingle();
        Field56 = reader.ReadSingle();
    }

    static string IEntry<StatusEntry>.TableName => TableName;

    static StatusEntry IEntry<StatusEntry>.CreateInstance(BinaryReader reader)
    {
        return new StatusEntry(reader);
    }
}
