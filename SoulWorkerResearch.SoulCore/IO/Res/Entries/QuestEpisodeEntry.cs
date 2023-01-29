global using QuestEpisodeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class QuestEpisodeEntry : IEntry<QuestEpisodeEntry>
{
    public const string TableName = "tb_Quest_Episode";

    public QuestEpisodeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
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
    public uint Field45 { get; set; }
    public uint Field46 { get; set; }
    public uint Field47 { get; set; }
    public byte Field48 { get; set; }
    public ushort Field49 { get; set; }
    public byte Field50 { get; set; }
    public byte Field51 { get; set; }
    public uint Field52 { get; set; }
    public byte Field53 { get; set; }
    public uint Field54 { get; set; }
    public byte Field55 { get; set; }
    public byte Field56 { get; set; }
    public uint Field57 { get; set; }
    public byte Field58 { get; set; }
    public uint Field59 { get; set; }
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
    public byte Field70 { get; set; }
    public uint Field71 { get; set; }
    public uint Field72 { get; set; }
    public uint Field73 { get; set; }
    public uint Field74 { get; set; }
    public uint Field75 { get; set; }
    public uint Field76 { get; set; }
    public byte Field77 { get; set; }
    public byte Field78 { get; set; }
    public uint Field79 { get; set; }
    public uint Field80 { get; set; }
    public uint Field81 { get; set; }
    public uint Field82 { get; set; }
    public uint Field83 { get; set; }
    public uint Field84 { get; set; }
    public uint Field85 { get; set; }
    public uint Field86 { get; set; }
    public uint Field87 { get; set; }
    public uint Field88 { get; set; }
    public uint Field89 { get; set; }
    public uint Field90 { get; set; }
    public string Field91 { get; set; } = string.Empty;
    public byte Field92 { get; set; }
    public uint Field93 { get; set; }
    public uint Field94 { get; set; }
    public uint Field95 { get; set; }
    public uint Field96 { get; set; }
    public uint Field97 { get; set; }
    public uint Field98 { get; set; }
    public uint Field99 { get; set; }
    public byte Field100 { get; set; }
    public uint Field101 { get; set; }
    public uint Field102 { get; set; }
    public uint Field103 { get; set; }
    public uint Field104 { get; set; }
    public uint Field105 { get; set; }
    public uint Field106 { get; set; }
    public uint Field107 { get; set; }
    public uint Field108 { get; set; }
    public uint Field109 { get; set; }
    public uint Field110 { get; set; }
    public byte Field111 { get; set; }
    public uint Field112 { get; set; }
    public uint Field113 { get; set; }
    public uint Field114 { get; set; }
    public uint Field115 { get; set; }
    public uint Field116 { get; set; }
    public uint Field117 { get; set; }
    public uint Field118 { get; set; }
    public uint Field119 { get; set; }
    public uint Field120 { get; set; }
    public uint Field121 { get; set; }
    public uint Field122 { get; set; }
    public uint Field123 { get; set; }
    public uint Field124 { get; set; }
    public uint Field125 { get; set; }
    public uint Field126 { get; set; }
    public byte Field127 { get; set; }
    public byte Field128 { get; set; }
    public uint Field129 { get; set; }
    public uint Field130 { get; set; }
    public uint Field131 { get; set; }
    public uint Field132 { get; set; }
    public uint Field133 { get; set; }
    public uint Field134 { get; set; }
    public uint Field135 { get; set; }
    public uint Field136 { get; set; }
    public uint Field137 { get; set; }
    public uint Field138 { get; set; }
    public ushort Field139 { get; set; }
    public string Field140 { get; set; } = string.Empty;

    public QuestEpisodeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
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
        Field45 = reader.ReadUInt32();
        Field46 = reader.ReadUInt32();
        Field47 = reader.ReadUInt32();
        Field48 = reader.ReadByte();
        Field49 = reader.ReadUInt16();
        Field50 = reader.ReadByte();
        Field51 = reader.ReadByte();
        Field52 = reader.ReadUInt32();
        Field53 = reader.ReadByte();
        Field54 = reader.ReadUInt32();
        Field55 = reader.ReadByte();
        Field56 = reader.ReadByte();
        Field57 = reader.ReadUInt32();
        Field58 = reader.ReadByte();
        Field59 = reader.ReadUInt32();
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
        Field70 = reader.ReadByte();
        Field71 = reader.ReadUInt32();
        Field72 = reader.ReadUInt32();
        Field73 = reader.ReadUInt32();
        Field74 = reader.ReadUInt32();
        Field75 = reader.ReadUInt32();
        Field76 = reader.ReadUInt32();
        Field77 = reader.ReadByte();
        Field78 = reader.ReadByte();
        Field79 = reader.ReadUInt32();
        Field80 = reader.ReadUInt32();
        Field81 = reader.ReadUInt32();
        Field82 = reader.ReadUInt32();
        Field83 = reader.ReadUInt32();
        Field84 = reader.ReadUInt32();
        Field85 = reader.ReadUInt32();
        Field86 = reader.ReadUInt32();
        Field87 = reader.ReadUInt32();
        Field88 = reader.ReadUInt32();
        Field89 = reader.ReadUInt32();
        Field90 = reader.ReadUInt32();
        Field91 = reader.ReadUTF16UnicodeString();
        Field92 = reader.ReadByte();
        Field93 = reader.ReadUInt32();
        Field94 = reader.ReadUInt32();
        Field95 = reader.ReadUInt32();
        Field96 = reader.ReadUInt32();
        Field97 = reader.ReadUInt32();
        Field98 = reader.ReadUInt32();
        Field99 = reader.ReadUInt32();
        Field100 = reader.ReadByte();
        Field101 = reader.ReadUInt32();
        Field102 = reader.ReadUInt32();
        Field103 = reader.ReadUInt32();
        Field104 = reader.ReadUInt32();
        Field105 = reader.ReadUInt32();
        Field106 = reader.ReadUInt32();
        Field107 = reader.ReadUInt32();
        Field108 = reader.ReadUInt32();
        Field109 = reader.ReadUInt32();
        Field110 = reader.ReadUInt32();
        Field111 = reader.ReadByte();
        Field112 = reader.ReadUInt32();
        Field113 = reader.ReadUInt32();
        Field114 = reader.ReadUInt32();
        Field115 = reader.ReadUInt32();
        Field116 = reader.ReadUInt32();
        Field117 = reader.ReadUInt32();
        Field118 = reader.ReadUInt32();
        Field119 = reader.ReadUInt32();
        Field120 = reader.ReadUInt32();
        Field121 = reader.ReadUInt32();
        Field122 = reader.ReadUInt32();
        Field123 = reader.ReadUInt32();
        Field124 = reader.ReadUInt32();
        Field125 = reader.ReadUInt32();
        Field126 = reader.ReadUInt32();
        Field127 = reader.ReadByte();
        Field128 = reader.ReadByte();
        Field129 = reader.ReadUInt32();
        Field130 = reader.ReadUInt32();
        Field131 = reader.ReadUInt32();
        Field132 = reader.ReadUInt32();
        Field133 = reader.ReadUInt32();
        Field134 = reader.ReadUInt32();
        Field135 = reader.ReadUInt32();
        Field136 = reader.ReadUInt32();
        Field137 = reader.ReadUInt32();
        Field138 = reader.ReadUInt32();
        Field139 = reader.ReadUInt16();
        Field140 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<QuestEpisodeEntry>.TableName => TableName;

    static QuestEpisodeEntry IEntry<QuestEpisodeEntry>.CreateInstance(BinaryReader reader)
    {
        return new QuestEpisodeEntry(reader);
    }
}
