global using NpcKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class NpcEntry : IEntry<NpcEntry>
{
    public const string TableName = "tb_NPC";

    public NpcKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public byte Field9 { get; set; }
    public uint Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public byte Field25 { get; set; }
    public byte Field26 { get; set; }
    public byte Field27 { get; set; }
    public byte Field28 { get; set; }
    public uint Field29 { get; set; }
    public ushort Field30 { get; set; }
    public ushort Field31 { get; set; }
    public ushort Field32 { get; set; }
    public byte Field33 { get; set; }
    public byte Field34 { get; set; }
    public byte Field35 { get; set; }
    public byte Field36 { get; set; }
    public byte Field37 { get; set; }
    public byte Field38 { get; set; }
    public ushort Field39 { get; set; }
    public ushort Field40 { get; set; }
    public ushort Field41 { get; set; }
    public string Field42 { get; set; } = string.Empty;
    public byte Field43 { get; set; }
    public uint Field44 { get; set; }
    public uint Field45 { get; set; }
    public string Field46 { get; set; } = string.Empty;
    public ushort Field47 { get; set; }
    public ushort Field48 { get; set; }
    public ushort Field49 { get; set; }
    public ushort Field50 { get; set; }
    public ushort Field51 { get; set; }
    public ushort Field52 { get; set; }
    public ushort Field53 { get; set; }
    public ushort Field54 { get; set; }
    public ushort Field55 { get; set; }
    public ushort Field56 { get; set; }
    public ushort Field57 { get; set; }
    public ushort Field58 { get; set; }
    public ushort Field59 { get; set; }
    public ushort Field60 { get; set; }
    public ushort Field61 { get; set; }
    public ushort Field62 { get; set; }
    public string Field63 { get; set; } = string.Empty;
    public string Field64 { get; set; } = string.Empty;
    public string Field65 { get; set; } = string.Empty;
    public string Field66 { get; set; } = string.Empty;
    public string Field67 { get; set; } = string.Empty;

    public NpcEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadByte();
        Field27 = reader.ReadByte();
        Field28 = reader.ReadByte();
        Field29 = reader.ReadUInt32();
        Field30 = reader.ReadUInt16();
        Field31 = reader.ReadUInt16();
        Field32 = reader.ReadUInt16();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadByte();
        Field35 = reader.ReadByte();
        Field36 = reader.ReadByte();
        Field37 = reader.ReadByte();
        Field38 = reader.ReadByte();
        Field39 = reader.ReadUInt16();
        Field40 = reader.ReadUInt16();
        Field41 = reader.ReadUInt16();
        Field42 = reader.ReadUTF16UnicodeString();
        Field43 = reader.ReadByte();
        Field44 = reader.ReadUInt32();
        Field45 = reader.ReadUInt32();
        Field46 = reader.ReadUTF16UnicodeString();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadUInt16();
        Field49 = reader.ReadUInt16();
        Field50 = reader.ReadUInt16();
        Field51 = reader.ReadUInt16();
        Field52 = reader.ReadUInt16();
        Field53 = reader.ReadUInt16();
        Field54 = reader.ReadUInt16();
        Field55 = reader.ReadUInt16();
        Field56 = reader.ReadUInt16();
        Field57 = reader.ReadUInt16();
        Field58 = reader.ReadUInt16();
        Field59 = reader.ReadUInt16();
        Field60 = reader.ReadUInt16();
        Field61 = reader.ReadUInt16();
        Field62 = reader.ReadUInt16();
        Field63 = reader.ReadUTF16UnicodeString();
        Field64 = reader.ReadUTF16UnicodeString();
        Field65 = reader.ReadUTF16UnicodeString();
        Field66 = reader.ReadUTF16UnicodeString();
        Field67 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<NpcEntry>.TableName => TableName;

    static NpcEntry IEntry<NpcEntry>.CreateInstance(BinaryReader reader)
    {
        return new NpcEntry(reader);
    }
}
