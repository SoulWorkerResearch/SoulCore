global using MonsterKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MonsterEntry : IEntry<MonsterEntry>
{
    public const string TableName = "tb_Monster";

    public MonsterKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public byte Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public uint Field17 { get; set; }
    public byte Field18 { get; set; }
    public uint Field19 { get; set; }
    public byte Field20 { get; set; }
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public byte Field23 { get; set; }
    public byte Field24 { get; set; }
    public byte Field25 { get; set; }
    public byte Field26 { get; set; }
    public string Field27 { get; set; } = string.Empty;
    public string Field28 { get; set; } = string.Empty;
    public byte Field29 { get; set; }
    public byte Field30 { get; set; }
    public byte Field31 { get; set; }
    public uint Field32 { get; set; }
    public byte Field33 { get; set; }
    public byte Field34 { get; set; }
    public byte Field35 { get; set; }
    public byte Field36 { get; set; }
    public byte Field37 { get; set; }
    public byte Field38 { get; set; }
    public ushort Field39 { get; set; }
    public ushort Field40 { get; set; }
    public ushort Field41 { get; set; }
    public ushort Field42 { get; set; }
    public byte Field43 { get; set; }
    public uint Field44 { get; set; }
    public ushort Field45 { get; set; }
    public byte Field46 { get; set; }
    public byte Field47 { get; set; }
    public string Field48 { get; set; } = string.Empty;
    public byte Field49 { get; set; }
    public byte Field50 { get; set; }
    public uint Field51 { get; set; }
    public string Field52 { get; set; } = string.Empty;
    public string Field53 { get; set; } = string.Empty;
    public byte Field54 { get; set; }
    public short Field55 { get; set; }
    public byte Field56 { get; set; }
    public byte Field57 { get; set; }
    public byte Field58 { get; set; }
    public short Field59 { get; set; }
    public string Field60 { get; set; } = string.Empty;
    public string Field61 { get; set; } = string.Empty;
    public string Field62 { get; set; } = string.Empty;
    public byte Field63 { get; set; }
    public byte Field64 { get; set; }
    public byte Field65 { get; set; }
    public string Field66 { get; set; } = string.Empty;
    public string Field67 { get; set; } = string.Empty;
    public string Field68 { get; set; } = string.Empty;
    public uint Field69 { get; set; }
    public uint Field70 { get; set; }
    public uint Field71 { get; set; }
    public byte Field72 { get; set; }
    public byte Field73 { get; set; }
    public byte Field74 { get; set; }
    public uint Field75 { get; set; }
    public uint Field76 { get; set; }
    public uint Field77 { get; set; }
    public byte Field78 { get; set; }
    public byte Field79 { get; set; }
    public byte Field80 { get; set; }
    public string Field81 { get; set; } = string.Empty;
    public string Field82 { get; set; } = string.Empty;
    public string Field83 { get; set; } = string.Empty;
    public short Field84 { get; set; }
    public short Field85 { get; set; }
    public uint Field86 { get; set; }
    public uint Field87 { get; set; }
    public uint Field88 { get; set; }
    public uint Field89 { get; set; }
    public uint Field90 { get; set; }
    public uint Field91 { get; set; }
    public uint Field92 { get; set; }
    public uint Field93 { get; set; }
    public uint Field94 { get; set; }
    public uint Field95 { get; set; }
    public uint Field96 { get; set; }
    public uint Field97 { get; set; }
    public float Field98 { get; set; }
    public uint Field99 { get; set; }
    public byte Field100 { get; set; }
    public ushort Field101 { get; set; }
    public ushort Field102 { get; set; }
    public byte Field103 { get; set; }
    public byte Field104 { get; set; }
    public string Field105 { get; set; } = string.Empty;
    public ushort Field106 { get; set; }
    public ushort Field107 { get; set; }
    public float Field108 { get; set; }
    public short Field109 { get; set; }
    public byte Field110 { get; set; }
    public uint Field111 { get; set; }
    public ushort Field112 { get; set; }
    public ushort Field113 { get; set; }
    public byte Field114 { get; set; }
    public int Field115 { get; set; }
    public int Field116 { get; set; }
    public int Field117 { get; set; }
    public int Field118 { get; set; }
    public int Field119 { get; set; }
    public int Field120 { get; set; }
    public int Field121 { get; set; }
    public int Field122 { get; set; }
    public int Field123 { get; set; }
    public int Field124 { get; set; }
    public int Field125 { get; set; }
    public int Field126 { get; set; }
    public int Field127 { get; set; }
    public int Field128 { get; set; }
    public int Field129 { get; set; }
    public int Field130 { get; set; }
    public int Field131 { get; set; }
    public int Field132 { get; set; }
    public int Field133 { get; set; }
    public int Field134 { get; set; }
    public int Field135 { get; set; }
    public int Field136 { get; set; }
    public int Field137 { get; set; }
    public int Field138 { get; set; }
    public int Field139 { get; set; }
    public int Field140 { get; set; }
    public int Field141 { get; set; }
    public int Field142 { get; set; }
    public int Field143 { get; set; }
    public int Field144 { get; set; }
    public int Field145 { get; set; }
    public int Field146 { get; set; }
    public int Field147 { get; set; }
    public int Field148 { get; set; }
    public string Field149 { get; set; } = string.Empty;
    public string Field150 { get; set; } = string.Empty;
    public string Field151 { get; set; } = string.Empty;
    public string Field152 { get; set; } = string.Empty;
    public uint Field153 { get; set; }
    public byte Field154 { get; set; }
    public byte Field155 { get; set; }

    public MonsterEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadByte();
        Field24 = reader.ReadByte();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadByte();
        Field27 = reader.ReadUTF16UnicodeString();
        Field28 = reader.ReadUTF16UnicodeString();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadByte();
        Field31 = reader.ReadByte();
        Field32 = reader.ReadUInt32();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadByte();
        Field35 = reader.ReadByte();
        Field36 = reader.ReadByte();
        Field37 = reader.ReadByte();
        Field38 = reader.ReadByte();
        Field39 = reader.ReadUInt16();
        Field40 = reader.ReadUInt16();
        Field41 = reader.ReadUInt16();
        Field42 = reader.ReadUInt16();
        Field43 = reader.ReadByte();
        Field44 = reader.ReadUInt32();
        Field45 = reader.ReadUInt16();
        Field46 = reader.ReadByte();
        Field47 = reader.ReadByte();
        Field48 = reader.ReadUTF16UnicodeString();
        Field49 = reader.ReadByte();
        Field50 = reader.ReadByte();
        Field51 = reader.ReadUInt32();
        Field52 = reader.ReadUTF16UnicodeString();
        Field53 = reader.ReadUTF16UnicodeString();
        Field54 = reader.ReadByte();
        Field55 = reader.ReadInt16();
        Field56 = reader.ReadByte();
        Field57 = reader.ReadByte();
        Field58 = reader.ReadByte();
        Field59 = reader.ReadInt16();
        Field60 = reader.ReadUTF16UnicodeString();
        Field61 = reader.ReadUTF16UnicodeString();
        Field62 = reader.ReadUTF16UnicodeString();
        Field63 = reader.ReadByte();
        Field64 = reader.ReadByte();
        Field65 = reader.ReadByte();
        Field66 = reader.ReadUTF16UnicodeString();
        Field67 = reader.ReadUTF16UnicodeString();
        Field68 = reader.ReadUTF16UnicodeString();
        Field69 = reader.ReadUInt32();
        Field70 = reader.ReadUInt32();
        Field71 = reader.ReadUInt32();
        Field72 = reader.ReadByte();
        Field73 = reader.ReadByte();
        Field74 = reader.ReadByte();
        Field75 = reader.ReadUInt32();
        Field76 = reader.ReadUInt32();
        Field77 = reader.ReadUInt32();
        Field78 = reader.ReadByte();
        Field79 = reader.ReadByte();
        Field80 = reader.ReadByte();
        Field81 = reader.ReadUTF16UnicodeString();
        Field82 = reader.ReadUTF16UnicodeString();
        Field83 = reader.ReadUTF16UnicodeString();
        Field84 = reader.ReadInt16();
        Field85 = reader.ReadInt16();
        Field86 = reader.ReadUInt32();
        Field87 = reader.ReadUInt32();
        Field88 = reader.ReadUInt32();
        Field89 = reader.ReadUInt32();
        Field90 = reader.ReadUInt32();
        Field91 = reader.ReadUInt32();
        Field92 = reader.ReadUInt32();
        Field93 = reader.ReadUInt32();
        Field94 = reader.ReadUInt32();
        Field95 = reader.ReadUInt32();
        Field96 = reader.ReadUInt32();
        Field97 = reader.ReadUInt32();
        Field98 = reader.ReadSingle();
        Field99 = reader.ReadUInt32();
        Field100 = reader.ReadByte();
        Field101 = reader.ReadUInt16();
        Field102 = reader.ReadUInt16();
        Field103 = reader.ReadByte();
        Field104 = reader.ReadByte();
        Field105 = reader.ReadUTF16UnicodeString();
        Field106 = reader.ReadUInt16();
        Field107 = reader.ReadUInt16();
        Field108 = reader.ReadSingle();
        Field109 = reader.ReadInt16();
        Field110 = reader.ReadByte();
        Field111 = reader.ReadUInt32();
        Field112 = reader.ReadUInt16();
        Field113 = reader.ReadUInt16();
        Field114 = reader.ReadByte();
        Field115 = reader.ReadInt32();
        Field116 = reader.ReadInt32();
        Field117 = reader.ReadInt32();
        Field118 = reader.ReadInt32();
        Field119 = reader.ReadInt32();
        Field120 = reader.ReadInt32();
        Field121 = reader.ReadInt32();
        Field122 = reader.ReadInt32();
        Field123 = reader.ReadInt32();
        Field124 = reader.ReadInt32();
        Field125 = reader.ReadInt32();
        Field126 = reader.ReadInt32();
        Field127 = reader.ReadInt32();
        Field128 = reader.ReadInt32();
        Field129 = reader.ReadInt32();
        Field130 = reader.ReadInt32();
        Field131 = reader.ReadInt32();
        Field132 = reader.ReadInt32();
        Field133 = reader.ReadInt32();
        Field134 = reader.ReadInt32();
        Field135 = reader.ReadInt32();
        Field136 = reader.ReadInt32();
        Field137 = reader.ReadInt32();
        Field138 = reader.ReadInt32();
        Field139 = reader.ReadInt32();
        Field140 = reader.ReadInt32();
        Field141 = reader.ReadInt32();
        Field142 = reader.ReadInt32();
        Field143 = reader.ReadInt32();
        Field144 = reader.ReadInt32();
        Field145 = reader.ReadInt32();
        Field146 = reader.ReadInt32();
        Field147 = reader.ReadInt32();
        Field148 = reader.ReadInt32();
        Field149 = reader.ReadUTF16UnicodeString();
        Field150 = reader.ReadUTF16UnicodeString();
        Field151 = reader.ReadUTF16UnicodeString();
        Field152 = reader.ReadUTF16UnicodeString();
        Field153 = reader.ReadUInt32();
        Field154 = reader.ReadByte();
        Field155 = reader.ReadByte();
    }

    static string IEntry<MonsterEntry>.TableName => TableName;

    static MonsterEntry IEntry<MonsterEntry>.CreateInstance(BinaryReader reader)
    {
        return new MonsterEntry(reader);
    }
}
