global using InteractionObjectKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class InteractionObjectEntry : IEntry<InteractionObjectEntry>
{
    public const string TableName = "tb_Interaction_Object";

    public InteractionObjectKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public string Field8 { get; set; } = string.Empty;
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public uint Field17 { get; set; }
    public uint Field18 { get; set; }
    public short Field19 { get; set; }
    public short Field20 { get; set; }
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public byte Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public uint Field27 { get; set; }
    public uint Field28 { get; set; }
    public byte Field29 { get; set; }
    public string Field30 { get; set; } = string.Empty;
    public string Field31 { get; set; } = string.Empty;
    public string Field32 { get; set; } = string.Empty;
    public string Field33 { get; set; } = string.Empty;
    public string Field34 { get; set; } = string.Empty;
    public string Field35 { get; set; } = string.Empty;
    public string Field36 { get; set; } = string.Empty;
    public string Field37 { get; set; } = string.Empty;
    public string Field38 { get; set; } = string.Empty;
    public string Field39 { get; set; } = string.Empty;
    public float Field40 { get; set; }
    public short Field41 { get; set; }
    public short Field42 { get; set; }
    public short Field43 { get; set; }
    public short Field44 { get; set; }
    public short Field45 { get; set; }
    public short Field46 { get; set; }

    public InteractionObjectEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadInt16();
        Field20 = reader.ReadInt16();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadByte();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadUInt32();
        Field28 = reader.ReadUInt32();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadUTF16UnicodeString();
        Field31 = reader.ReadUTF16UnicodeString();
        Field32 = reader.ReadUTF16UnicodeString();
        Field33 = reader.ReadUTF16UnicodeString();
        Field34 = reader.ReadUTF16UnicodeString();
        Field35 = reader.ReadUTF16UnicodeString();
        Field36 = reader.ReadUTF16UnicodeString();
        Field37 = reader.ReadUTF16UnicodeString();
        Field38 = reader.ReadUTF16UnicodeString();
        Field39 = reader.ReadUTF16UnicodeString();
        Field40 = reader.ReadSingle();
        Field41 = reader.ReadInt16();
        Field42 = reader.ReadInt16();
        Field43 = reader.ReadInt16();
        Field44 = reader.ReadInt16();
        Field45 = reader.ReadInt16();
        Field46 = reader.ReadInt16();
    }

    static string IEntry<InteractionObjectEntry>.TableName => TableName;

    static InteractionObjectEntry IEntry<InteractionObjectEntry>.CreateInstance(BinaryReader reader)
    {
        return new InteractionObjectEntry(reader);
    }
}
