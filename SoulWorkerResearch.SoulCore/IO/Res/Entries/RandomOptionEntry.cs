global using RandomOptionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RandomOptionEntry : IEntry<RandomOptionEntry>
{
    public const string TableName = "tb_Random_Option";

    public RandomOptionKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public ushort Field10 { get; set; }
    public ushort Field11 { get; set; }
    public ushort Field12 { get; set; }
    public ushort Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public ushort Field19 { get; set; }
    public ushort Field20 { get; set; }
    public ushort Field21 { get; set; }
    public ushort Field22 { get; set; }
    public ushort Field23 { get; set; }
    public ushort Field24 { get; set; }
    public ushort Field25 { get; set; }
    public ushort Field26 { get; set; }
    public ushort Field27 { get; set; }
    public ushort Field28 { get; set; }
    public int Field29 { get; set; }
    public int Field30 { get; set; }
    public int Field31 { get; set; }
    public int Field32 { get; set; }
    public int Field33 { get; set; }
    public int Field34 { get; set; }
    public int Field35 { get; set; }
    public int Field36 { get; set; }
    public int Field37 { get; set; }
    public int Field38 { get; set; }
    public int Field39 { get; set; }
    public int Field40 { get; set; }
    public int Field41 { get; set; }
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
    public int Field62 { get; set; }
    public int Field63 { get; set; }
    public int Field64 { get; set; }
    public int Field65 { get; set; }
    public int Field66 { get; set; }
    public int Field67 { get; set; }
    public int Field68 { get; set; }
    public int Field69 { get; set; }
    public int Field70 { get; set; }
    public int Field71 { get; set; }
    public int Field72 { get; set; }
    public int Field73 { get; set; }
    public int Field74 { get; set; }
    public int Field75 { get; set; }
    public int Field76 { get; set; }
    public int Field77 { get; set; }
    public int Field78 { get; set; }
    public uint Field79 { get; set; }

    public RandomOptionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadUInt16();
        Field21 = reader.ReadUInt16();
        Field22 = reader.ReadUInt16();
        Field23 = reader.ReadUInt16();
        Field24 = reader.ReadUInt16();
        Field25 = reader.ReadUInt16();
        Field26 = reader.ReadUInt16();
        Field27 = reader.ReadUInt16();
        Field28 = reader.ReadUInt16();
        Field29 = reader.ReadInt32();
        Field30 = reader.ReadInt32();
        Field31 = reader.ReadInt32();
        Field32 = reader.ReadInt32();
        Field33 = reader.ReadInt32();
        Field34 = reader.ReadInt32();
        Field35 = reader.ReadInt32();
        Field36 = reader.ReadInt32();
        Field37 = reader.ReadInt32();
        Field38 = reader.ReadInt32();
        Field39 = reader.ReadInt32();
        Field40 = reader.ReadInt32();
        Field41 = reader.ReadInt32();
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
        Field62 = reader.ReadInt32();
        Field63 = reader.ReadInt32();
        Field64 = reader.ReadInt32();
        Field65 = reader.ReadInt32();
        Field66 = reader.ReadInt32();
        Field67 = reader.ReadInt32();
        Field68 = reader.ReadInt32();
        Field69 = reader.ReadInt32();
        Field70 = reader.ReadInt32();
        Field71 = reader.ReadInt32();
        Field72 = reader.ReadInt32();
        Field73 = reader.ReadInt32();
        Field74 = reader.ReadInt32();
        Field75 = reader.ReadInt32();
        Field76 = reader.ReadInt32();
        Field77 = reader.ReadInt32();
        Field78 = reader.ReadInt32();
        Field79 = reader.ReadUInt32();
    }

    static string IEntry<RandomOptionEntry>.TableName => TableName;

    static RandomOptionEntry IEntry<RandomOptionEntry>.CreateInstance(BinaryReader reader)
    {
        return new RandomOptionEntry(reader);
    }
}
