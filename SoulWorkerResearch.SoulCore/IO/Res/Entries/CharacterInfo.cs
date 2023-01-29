global using CharacterInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CharacterInfoEntry : IEntry<CharacterInfoEntry>
{
    public const string TableName = "tb_Character_Info";

    public CharacterInfoKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;
    public string Field9 { get; set; } = string.Empty;
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
    public short Field27 { get; set; }
    public short Field28 { get; set; }
    public short Field29 { get; set; }
    public short Field30 { get; set; }
    public short Field31 { get; set; }
    public byte Field32 { get; set; }
    public uint Field33 { get; set; }
    public uint Field34 { get; set; }
    public uint Field35 { get; set; }
    public ushort Field36 { get; set; }
    public float Field37 { get; set; }
    public short Field38 { get; set; }
    public ushort Field39 { get; set; }
    public ushort Field40 { get; set; }
    public ushort Field41 { get; set; }
    public ushort Field42 { get; set; }
    public ushort Field43 { get; set; }
    public ushort Field44 { get; set; }
    public float Field45 { get; set; }
    public byte Field46 { get; set; }
    public ushort Field47 { get; set; }
    public ushort Field48 { get; set; }
    public ushort Field49 { get; set; }
    public ushort Field50 { get; set; }
    public ushort Field51 { get; set; }
    public ushort Field52 { get; set; }
    public ushort Field53 { get; set; }
    public ushort Field54 { get; set; }
    public ushort Field55 { get; set; }
    public short Field56 { get; set; }
    public ushort Field57 { get; set; }
    public ushort Field58 { get; set; }
    public ushort Field59 { get; set; }
    public uint Field60 { get; set; }
    public uint Field61 { get; set; }
    public uint Field62 { get; set; }
    public uint Field63 { get; set; }
    public uint Field64 { get; set; }
    public uint Field65 { get; set; }
    public uint Field66 { get; set; }
    public uint Field67 { get; set; }
    public uint Field68 { get; set; }
    public uint Field69 { get; set; }
    public uint Field70 { get; set; }
    public uint Field71 { get; set; }
    public uint Field72 { get; set; }
    public uint Field73 { get; set; }
    public uint Field74 { get; set; }
    public uint Field75 { get; set; }
    public uint Field76 { get; set; }
    public uint Field77 { get; set; }
    public uint Field78 { get; set; }
    public uint Field79 { get; set; }
    public ushort Field80 { get; set; }
    public float Field81 { get; set; }
    public uint Field82 { get; set; }
    public uint Field83 { get; set; }
    public ushort Field84 { get; set; }
    public byte Field85 { get; set; }

    public CharacterInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUTF16UnicodeString();
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
        Field27 = reader.ReadInt16();
        Field28 = reader.ReadInt16();
        Field29 = reader.ReadInt16();
        Field30 = reader.ReadInt16();
        Field31 = reader.ReadInt16();
        Field32 = reader.ReadByte();
        Field33 = reader.ReadUInt32();
        Field34 = reader.ReadUInt32();
        Field35 = reader.ReadUInt32();
        Field36 = reader.ReadUInt16();
        Field37 = reader.ReadSingle();
        Field38 = reader.ReadInt16();
        Field39 = reader.ReadUInt16();
        Field40 = reader.ReadUInt16();
        Field41 = reader.ReadUInt16();
        Field42 = reader.ReadUInt16();
        Field43 = reader.ReadUInt16();
        Field44 = reader.ReadUInt16();
        Field45 = reader.ReadSingle();
        Field46 = reader.ReadByte();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadUInt16();
        Field49 = reader.ReadUInt16();
        Field50 = reader.ReadUInt16();
        Field51 = reader.ReadUInt16();
        Field52 = reader.ReadUInt16();
        Field53 = reader.ReadUInt16();
        Field54 = reader.ReadUInt16();
        Field55 = reader.ReadUInt16();
        Field56 = reader.ReadInt16();
        Field57 = reader.ReadUInt16();
        Field58 = reader.ReadUInt16();
        Field59 = reader.ReadUInt16();
        Field60 = reader.ReadUInt32();
        Field61 = reader.ReadUInt32();
        Field62 = reader.ReadUInt32();
        Field63 = reader.ReadUInt32();
        Field64 = reader.ReadUInt32();
        Field65 = reader.ReadUInt32();
        Field66 = reader.ReadUInt32();
        Field67 = reader.ReadUInt32();
        Field68 = reader.ReadUInt32();
        Field69 = reader.ReadUInt32();
        Field70 = reader.ReadUInt32();
        Field71 = reader.ReadUInt32();
        Field72 = reader.ReadUInt32();
        Field73 = reader.ReadUInt32();
        Field74 = reader.ReadUInt32();
        Field75 = reader.ReadUInt32();
        Field76 = reader.ReadUInt32();
        Field77 = reader.ReadUInt32();
        Field78 = reader.ReadUInt32();
        Field79 = reader.ReadUInt32();
        Field80 = reader.ReadUInt16();
        Field81 = reader.ReadSingle();
        Field82 = reader.ReadUInt32();
        Field83 = reader.ReadUInt32();
        Field84 = reader.ReadUInt16();
        Field85 = reader.ReadByte();
    }

    static string IEntry<CharacterInfoEntry>.TableName => TableName;

    static CharacterInfoEntry IEntry<CharacterInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new CharacterInfoEntry(reader);
    }
}
