global using ReinforceKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ReinforceEntry : IEntry<ReinforceEntry>
{
    public const string TableName = "tb_Reinforce";

    public ReinforceKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
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
    public uint Field42 { get; set; }
    public uint Field43 { get; set; }
    public uint Field44 { get; set; }
    public ushort Field45 { get; set; }
    public ushort Field46 { get; set; }
    public ushort Field47 { get; set; }
    public ushort Field48 { get; set; }
    public ushort Field49 { get; set; }
    public ushort Field50 { get; set; }
    public ushort Field51 { get; set; }
    public ushort Field52 { get; set; }
    public ushort Field53 { get; set; }
    public ushort Field54 { get; set; }
    public uint Field55 { get; set; }
    public uint Field56 { get; set; }
    public uint Field57 { get; set; }
    public uint Field58 { get; set; }
    public uint Field59 { get; set; }
    public uint Field60 { get; set; }
    public uint Field61 { get; set; }
    public uint Field62 { get; set; }
    public uint Field63 { get; set; }
    public uint Field64 { get; set; }
    public ushort Field65 { get; set; }
    public ushort Field66 { get; set; }
    public ushort Field67 { get; set; }
    public ushort Field68 { get; set; }
    public ushort Field69 { get; set; }
    public ushort Field70 { get; set; }
    public ushort Field71 { get; set; }
    public ushort Field72 { get; set; }
    public ushort Field73 { get; set; }
    public ushort Field74 { get; set; }
    public ushort Field75 { get; set; }
    public ushort Field76 { get; set; }
    public ushort Field77 { get; set; }
    public ushort Field78 { get; set; }
    public ushort Field79 { get; set; }
    public ushort Field80 { get; set; }
    public ushort Field81 { get; set; }
    public ushort Field82 { get; set; }
    public ushort Field83 { get; set; }
    public ushort Field84 { get; set; }
    public ushort Field85 { get; set; }
    public ushort Field86 { get; set; }
    public ushort Field87 { get; set; }
    public ushort Field88 { get; set; }
    public ushort Field89 { get; set; }
    public ushort Field90 { get; set; }
    public ushort Field91 { get; set; }
    public ushort Field92 { get; set; }
    public ushort Field93 { get; set; }
    public ushort Field94 { get; set; }
    public float Field95 { get; set; }
    public float Field96 { get; set; }
    public float Field97 { get; set; }
    public float Field98 { get; set; }
    public float Field99 { get; set; }
    public float Field100 { get; set; }
    public float Field101 { get; set; }
    public float Field102 { get; set; }
    public float Field103 { get; set; }
    public float Field104 { get; set; }

    public ReinforceEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
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
        Field42 = reader.ReadUInt32();
        Field43 = reader.ReadUInt32();
        Field44 = reader.ReadUInt32();
        Field45 = reader.ReadUInt16();
        Field46 = reader.ReadUInt16();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadUInt16();
        Field49 = reader.ReadUInt16();
        Field50 = reader.ReadUInt16();
        Field51 = reader.ReadUInt16();
        Field52 = reader.ReadUInt16();
        Field53 = reader.ReadUInt16();
        Field54 = reader.ReadUInt16();
        Field55 = reader.ReadUInt32();
        Field56 = reader.ReadUInt32();
        Field57 = reader.ReadUInt32();
        Field58 = reader.ReadUInt32();
        Field59 = reader.ReadUInt32();
        Field60 = reader.ReadUInt32();
        Field61 = reader.ReadUInt32();
        Field62 = reader.ReadUInt32();
        Field63 = reader.ReadUInt32();
        Field64 = reader.ReadUInt32();
        Field65 = reader.ReadUInt16();
        Field66 = reader.ReadUInt16();
        Field67 = reader.ReadUInt16();
        Field68 = reader.ReadUInt16();
        Field69 = reader.ReadUInt16();
        Field70 = reader.ReadUInt16();
        Field71 = reader.ReadUInt16();
        Field72 = reader.ReadUInt16();
        Field73 = reader.ReadUInt16();
        Field74 = reader.ReadUInt16();
        Field75 = reader.ReadUInt16();
        Field76 = reader.ReadUInt16();
        Field77 = reader.ReadUInt16();
        Field78 = reader.ReadUInt16();
        Field79 = reader.ReadUInt16();
        Field80 = reader.ReadUInt16();
        Field81 = reader.ReadUInt16();
        Field82 = reader.ReadUInt16();
        Field83 = reader.ReadUInt16();
        Field84 = reader.ReadUInt16();
        Field85 = reader.ReadUInt16();
        Field86 = reader.ReadUInt16();
        Field87 = reader.ReadUInt16();
        Field88 = reader.ReadUInt16();
        Field89 = reader.ReadUInt16();
        Field90 = reader.ReadUInt16();
        Field91 = reader.ReadUInt16();
        Field92 = reader.ReadUInt16();
        Field93 = reader.ReadUInt16();
        Field94 = reader.ReadUInt16();
        Field95 = reader.ReadSingle();
        Field96 = reader.ReadSingle();
        Field97 = reader.ReadSingle();
        Field98 = reader.ReadSingle();
        Field99 = reader.ReadSingle();
        Field100 = reader.ReadSingle();
        Field101 = reader.ReadSingle();
        Field102 = reader.ReadSingle();
        Field103 = reader.ReadSingle();
        Field104 = reader.ReadSingle();
    }

    static string IEntry<ReinforceEntry>.TableName => TableName;

    static ReinforceEntry IEntry<ReinforceEntry>.CreateInstance(BinaryReader reader)
    {
        return new ReinforceEntry(reader);
    }
}
