global using CustomizeHairKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomizeHairEntry : IEntry<CustomizeHairEntry>
{
    public const string TableName = "tb_Customize_Hair";

    public CustomizeHairKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
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
    public string Field31 { get; set; } = string.Empty;
    public string Field32 { get; set; } = string.Empty;
    public string Field33 { get; set; } = string.Empty;
    public string Field34 { get; set; } = string.Empty;
    public string Field35 { get; set; } = string.Empty;
    public string Field36 { get; set; } = string.Empty;
    public string Field37 { get; set; } = string.Empty;
    public string Field38 { get; set; } = string.Empty;
    public string Field39 { get; set; } = string.Empty;
    public string Field40 { get; set; } = string.Empty;
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

    public CustomizeHairEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
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
        Field31 = reader.ReadUTF16UnicodeString();
        Field32 = reader.ReadUTF16UnicodeString();
        Field33 = reader.ReadUTF16UnicodeString();
        Field34 = reader.ReadUTF16UnicodeString();
        Field35 = reader.ReadUTF16UnicodeString();
        Field36 = reader.ReadUTF16UnicodeString();
        Field37 = reader.ReadUTF16UnicodeString();
        Field38 = reader.ReadUTF16UnicodeString();
        Field39 = reader.ReadUTF16UnicodeString();
        Field40 = reader.ReadUTF16UnicodeString();
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
    }

    static string IEntry<CustomizeHairEntry>.TableName => TableName;

    static CustomizeHairEntry IEntry<CustomizeHairEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomizeHairEntry(reader);
    }
}
