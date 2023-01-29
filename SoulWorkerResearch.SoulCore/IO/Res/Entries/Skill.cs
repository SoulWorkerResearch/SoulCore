global using SkillKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SkillEntry : IEntry<SkillEntry>
{
    public const string TableName = "tb_Skill";

    public SkillKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }
    public ushort Field21 { get; set; }
    public float Field22 { get; set; }
    public float Field23 { get; set; }
    public float Field24 { get; set; }
    public float Field25 { get; set; }
    public float Field26 { get; set; }
    public byte Field27 { get; set; }
    public ushort Field28 { get; set; }
    public byte Field29 { get; set; }
    public byte Field30 { get; set; }
    public byte Field31 { get; set; }
    public uint Field32 { get; set; }
    public byte Field33 { get; set; }
    public byte Field34 { get; set; }
    public byte Field35 { get; set; }
    public byte Field36 { get; set; }
    public byte Field37 { get; set; }
    public uint Field38 { get; set; }
    public uint Field39 { get; set; }
    public uint Field40 { get; set; }
    public uint Field41 { get; set; }
    public uint Field42 { get; set; }
    public uint Field43 { get; set; }
    public uint Field44 { get; set; }
    public byte Field45 { get; set; }
    public ushort Field46 { get; set; }
    public ushort Field47 { get; set; }
    public byte Field48 { get; set; }
    public byte Field49 { get; set; }
    public byte Field50 { get; set; }
    public byte Field51 { get; set; }
    public byte Field52 { get; set; }
    public byte Field53 { get; set; }
    public uint Field54 { get; set; }
    public byte Field55 { get; set; }
    public uint Field56 { get; set; }
    public uint Field57 { get; set; }
    public byte Field58 { get; set; }
    public ushort Field59 { get; set; }
    public string Field60 { get; set; } = string.Empty;
    public ushort Field61 { get; set; }
    public uint Field62 { get; set; }
    public byte Field63 { get; set; }
    public string Field64 { get; set; } = string.Empty;
    public string Field65 { get; set; } = string.Empty;
    public string Field66 { get; set; } = string.Empty;
    public string Field67 { get; set; } = string.Empty;
    public byte Field68 { get; set; }
    public uint Field69 { get; set; }
    public ushort Field70 { get; set; }
    public byte Field71 { get; set; }
    public byte Field72 { get; set; }
    public ushort Field73 { get; set; }
    public string Field74 { get; set; } = string.Empty;
    public string Field75 { get; set; } = string.Empty;
    public string Field76 { get; set; } = string.Empty;
    public byte Field77 { get; set; }
    public string Field78 { get; set; } = string.Empty;
    public string Field79 { get; set; } = string.Empty;
    public byte Field80 { get; set; }
    public byte Field81 { get; set; }
    public byte Field82 { get; set; }
    public byte Field83 { get; set; }
    public byte Field84 { get; set; }
    public byte Field85 { get; set; }
    public uint Field86 { get; set; }
    public uint Field87 { get; set; }

    public SkillEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadUInt16();
        Field22 = reader.ReadSingle();
        Field23 = reader.ReadSingle();
        Field24 = reader.ReadSingle();
        Field25 = reader.ReadSingle();
        Field26 = reader.ReadSingle();
        Field27 = reader.ReadByte();
        Field28 = reader.ReadUInt16();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadByte();
        Field31 = reader.ReadByte();
        Field32 = reader.ReadUInt32();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadByte();
        Field35 = reader.ReadByte();
        Field36 = reader.ReadByte();
        Field37 = reader.ReadByte();
        Field38 = reader.ReadUInt32();
        Field39 = reader.ReadUInt32();
        Field40 = reader.ReadUInt32();
        Field41 = reader.ReadUInt32();
        Field42 = reader.ReadUInt32();
        Field43 = reader.ReadUInt32();
        Field44 = reader.ReadUInt32();
        Field45 = reader.ReadByte();
        Field46 = reader.ReadUInt16();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadByte();
        Field49 = reader.ReadByte();
        Field50 = reader.ReadByte();
        Field51 = reader.ReadByte();
        Field52 = reader.ReadByte();
        Field53 = reader.ReadByte();
        Field54 = reader.ReadUInt32();
        Field55 = reader.ReadByte();
        Field56 = reader.ReadUInt32();
        Field57 = reader.ReadUInt32();
        Field58 = reader.ReadByte();
        Field59 = reader.ReadUInt16();
        Field60 = reader.ReadUTF16UnicodeString();
        Field61 = reader.ReadUInt16();
        Field62 = reader.ReadUInt32();
        Field63 = reader.ReadByte();
        Field64 = reader.ReadUTF16UnicodeString();
        Field65 = reader.ReadUTF16UnicodeString();
        Field66 = reader.ReadUTF16UnicodeString();
        Field67 = reader.ReadUTF16UnicodeString();
        Field68 = reader.ReadByte();
        Field69 = reader.ReadUInt32();
        Field70 = reader.ReadUInt16();
        Field71 = reader.ReadByte();
        Field72 = reader.ReadByte();
        Field73 = reader.ReadUInt16();
        Field74 = reader.ReadUTF16UnicodeString();
        Field75 = reader.ReadUTF16UnicodeString();
        Field76 = reader.ReadUTF16UnicodeString();
        Field77 = reader.ReadByte();
        Field78 = reader.ReadUTF16UnicodeString();
        Field79 = reader.ReadUTF16UnicodeString();
        Field80 = reader.ReadByte();
        Field81 = reader.ReadByte();
        Field82 = reader.ReadByte();
        Field83 = reader.ReadByte();
        Field84 = reader.ReadByte();
        Field85 = reader.ReadByte();
        Field86 = reader.ReadUInt32();
        Field87 = reader.ReadUInt32();
    }

    static string IEntry<SkillEntry>.TableName => TableName;

    static SkillEntry IEntry<SkillEntry>.CreateInstance(BinaryReader reader)
    {
        return new SkillEntry(reader);
    }
}
