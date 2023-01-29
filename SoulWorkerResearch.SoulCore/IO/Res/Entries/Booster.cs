global using BoosterKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BoosterEntry : IEntry<BoosterEntry>
{
    public const string TableName = "tb_Booster";

    public BoosterKeyType Id { get; set; }
    public ushort Field1 { get; set; }
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
    public ushort Field32 { get; set; }
    public ushort Field33 { get; set; }
    public ushort Field34 { get; set; }
    public ushort Field35 { get; set; }
    public ushort Field36 { get; set; }
    public ushort Field37 { get; set; }
    public ushort Field38 { get; set; }
    public ushort Field39 { get; set; }
    public ushort Field40 { get; set; }
    public ushort Field41 { get; set; }
    public ushort Field42 { get; set; }
    public byte Field43 { get; set; }
    public uint Field44 { get; set; }

    public BoosterEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
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
        Field32 = reader.ReadUInt16();
        Field33 = reader.ReadUInt16();
        Field34 = reader.ReadUInt16();
        Field35 = reader.ReadUInt16();
        Field36 = reader.ReadUInt16();
        Field37 = reader.ReadUInt16();
        Field38 = reader.ReadUInt16();
        Field39 = reader.ReadUInt16();
        Field40 = reader.ReadUInt16();
        Field41 = reader.ReadUInt16();
        Field42 = reader.ReadUInt16();
        Field43 = reader.ReadByte();
        Field44 = reader.ReadUInt32();
    }

    static string IEntry<BoosterEntry>.TableName => TableName;

    static BoosterEntry IEntry<BoosterEntry>.CreateInstance(BinaryReader reader)
    {
        return new BoosterEntry(reader);
    }
}
