global using MyroomFurnitureKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MyroomFurnitureEntry : IEntry<MyroomFurnitureEntry>
{
    public const string TableName = "tb_Myroom_Furniture";

    public MyroomFurnitureKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
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
    public string Field18 { get; set; } = string.Empty;
    public uint Field19 { get; set; }
    public uint Field20 { get; set; }
    public string Field21 { get; set; } = string.Empty;
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public string Field24 { get; set; } = string.Empty;
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public string Field27 { get; set; } = string.Empty;
    public uint Field28 { get; set; }
    public string Field29 { get; set; } = string.Empty;
    public string Field30 { get; set; } = string.Empty;
    public uint Field31 { get; set; }
    public uint Field32 { get; set; }
    public uint Field33 { get; set; }
    public string Field34 { get; set; } = string.Empty;
    public string Field35 { get; set; } = string.Empty;
    public string Field36 { get; set; } = string.Empty;
    public uint Field37 { get; set; }
    public uint Field38 { get; set; }
    public string Field39 { get; set; } = string.Empty;
    public uint Field40 { get; set; }
    public string Field41 { get; set; } = string.Empty;
    public string Field42 { get; set; } = string.Empty;
    public string Field43 { get; set; } = string.Empty;
    public string Field44 { get; set; } = string.Empty;
    public string Field45 { get; set; } = string.Empty;
    public string Field46 { get; set; } = string.Empty;
    public string Field47 { get; set; } = string.Empty;
    public string Field48 { get; set; } = string.Empty;
    public string Field49 { get; set; } = string.Empty;
    public string Field50 { get; set; } = string.Empty;
    public string Field51 { get; set; } = string.Empty;
    public string Field52 { get; set; } = string.Empty;
    public string Field53 { get; set; } = string.Empty;
    public string Field54 { get; set; } = string.Empty;
    public string Field55 { get; set; } = string.Empty;
    public string Field56 { get; set; } = string.Empty;
    public string Field57 { get; set; } = string.Empty;
    public string Field58 { get; set; } = string.Empty;
    public string Field59 { get; set; } = string.Empty;
    public string Field60 { get; set; } = string.Empty;
    public string Field61 { get; set; } = string.Empty;
    public string Field62 { get; set; } = string.Empty;
    public string Field63 { get; set; } = string.Empty;
    public string Field64 { get; set; } = string.Empty;
    public string Field65 { get; set; } = string.Empty;
    public string Field66 { get; set; } = string.Empty;
    public string Field67 { get; set; } = string.Empty;
    public string Field68 { get; set; } = string.Empty;
    public string Field69 { get; set; } = string.Empty;

    public MyroomFurnitureEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUTF16UnicodeString();
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
        Field18 = reader.ReadUTF16UnicodeString();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadUInt32();
        Field21 = reader.ReadUTF16UnicodeString();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUTF16UnicodeString();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadUTF16UnicodeString();
        Field28 = reader.ReadUInt32();
        Field29 = reader.ReadUTF16UnicodeString();
        Field30 = reader.ReadUTF16UnicodeString();
        Field31 = reader.ReadUInt32();
        Field32 = reader.ReadUInt32();
        Field33 = reader.ReadUInt32();
        Field34 = reader.ReadUTF16UnicodeString();
        Field35 = reader.ReadUTF16UnicodeString();
        Field36 = reader.ReadUTF16UnicodeString();
        Field37 = reader.ReadUInt32();
        Field38 = reader.ReadUInt32();
        Field39 = reader.ReadUTF16UnicodeString();
        Field40 = reader.ReadUInt32();
        Field41 = reader.ReadUTF16UnicodeString();
        Field42 = reader.ReadUTF16UnicodeString();
        Field43 = reader.ReadUTF16UnicodeString();
        Field44 = reader.ReadUTF16UnicodeString();
        Field45 = reader.ReadUTF16UnicodeString();
        Field46 = reader.ReadUTF16UnicodeString();
        Field47 = reader.ReadUTF16UnicodeString();
        Field48 = reader.ReadUTF16UnicodeString();
        Field49 = reader.ReadUTF16UnicodeString();
        Field50 = reader.ReadUTF16UnicodeString();
        Field51 = reader.ReadUTF16UnicodeString();
        Field52 = reader.ReadUTF16UnicodeString();
        Field53 = reader.ReadUTF16UnicodeString();
        Field54 = reader.ReadUTF16UnicodeString();
        Field55 = reader.ReadUTF16UnicodeString();
        Field56 = reader.ReadUTF16UnicodeString();
        Field57 = reader.ReadUTF16UnicodeString();
        Field58 = reader.ReadUTF16UnicodeString();
        Field59 = reader.ReadUTF16UnicodeString();
        Field60 = reader.ReadUTF16UnicodeString();
        Field61 = reader.ReadUTF16UnicodeString();
        Field62 = reader.ReadUTF16UnicodeString();
        Field63 = reader.ReadUTF16UnicodeString();
        Field64 = reader.ReadUTF16UnicodeString();
        Field65 = reader.ReadUTF16UnicodeString();
        Field66 = reader.ReadUTF16UnicodeString();
        Field67 = reader.ReadUTF16UnicodeString();
        Field68 = reader.ReadUTF16UnicodeString();
        Field69 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<MyroomFurnitureEntry>.TableName => TableName;

    static MyroomFurnitureEntry IEntry<MyroomFurnitureEntry>.CreateInstance(BinaryReader reader)
    {
        return new MyroomFurnitureEntry(reader);
    }
}
