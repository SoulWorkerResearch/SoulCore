global using DiceEventKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DiceEventEntry : IEntry<DiceEventEntry>
{
    public const string TableName = "tb_Dice_Event";

    public DiceEventKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public uint Field4 { get; set; }
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
    public byte Field15 { get; set; }
    public byte Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public byte Field23 { get; set; }
    public byte Field24 { get; set; }
    public byte Field25 { get; set; }
    public byte Field26 { get; set; }
    public byte Field27 { get; set; }
    public byte Field28 { get; set; }
    public byte Field29 { get; set; }
    public byte Field30 { get; set; }
    public byte Field31 { get; set; }
    public byte Field32 { get; set; }
    public byte Field33 { get; set; }
    public byte Field34 { get; set; }
    public byte Field35 { get; set; }
    public byte Field36 { get; set; }
    public byte Field37 { get; set; }
    public byte Field38 { get; set; }
    public byte Field39 { get; set; }
    public uint Field40 { get; set; }
    public uint Field41 { get; set; }
    public uint Field42 { get; set; }
    public uint Field43 { get; set; }
    public uint Field44 { get; set; }
    public uint Field45 { get; set; }
    public uint Field46 { get; set; }
    public uint Field47 { get; set; }
    public uint Field48 { get; set; }
    public uint Field49 { get; set; }
    public uint Field50 { get; set; }
    public uint Field51 { get; set; }
    public uint Field52 { get; set; }
    public uint Field53 { get; set; }
    public uint Field54 { get; set; }
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

    public DiceEventEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUInt32();
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
        Field15 = reader.ReadByte();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadByte();
        Field24 = reader.ReadByte();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadByte();
        Field27 = reader.ReadByte();
        Field28 = reader.ReadByte();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadByte();
        Field31 = reader.ReadByte();
        Field32 = reader.ReadByte();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadByte();
        Field35 = reader.ReadByte();
        Field36 = reader.ReadByte();
        Field37 = reader.ReadByte();
        Field38 = reader.ReadByte();
        Field39 = reader.ReadByte();
        Field40 = reader.ReadUInt32();
        Field41 = reader.ReadUInt32();
        Field42 = reader.ReadUInt32();
        Field43 = reader.ReadUInt32();
        Field44 = reader.ReadUInt32();
        Field45 = reader.ReadUInt32();
        Field46 = reader.ReadUInt32();
        Field47 = reader.ReadUInt32();
        Field48 = reader.ReadUInt32();
        Field49 = reader.ReadUInt32();
        Field50 = reader.ReadUInt32();
        Field51 = reader.ReadUInt32();
        Field52 = reader.ReadUInt32();
        Field53 = reader.ReadUInt32();
        Field54 = reader.ReadUInt32();
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
    }

    static string IEntry<DiceEventEntry>.TableName => TableName;

    static DiceEventEntry IEntry<DiceEventEntry>.CreateInstance(BinaryReader reader)
    {
        return new DiceEventEntry(reader);
    }
}
