global using ItemKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemEntry : IEntry<ItemEntry>
{
    public const string TableName = "tb_Item";

    public ItemKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public ushort Field9 { get; set; }
    public byte Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public ushort Field14 { get; set; }
    public byte Field15 { get; set; }
    public byte Field16 { get; set; }
    public byte Field17 { get; set; }
    public byte Field18 { get; set; }
    public uint Field19 { get; set; }
    public string Field20 { get; set; } = string.Empty;
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public uint Field27 { get; set; }
    public uint Field28 { get; set; }
    public byte Field29 { get; set; }
    public byte Field30 { get; set; }
    public byte Field31 { get; set; }
    public byte Field32 { get; set; }
    public byte Field33 { get; set; }
    public uint Field34 { get; set; }
    public uint Field35 { get; set; }
    public uint Field36 { get; set; }
    public uint Field37 { get; set; }
    public uint Field38 { get; set; }
    public int Field39 { get; set; }
    public int Field40 { get; set; }
    public int Field41 { get; set; }
    public int Field42 { get; set; }
    public int Field43 { get; set; }
    public uint Field44 { get; set; }
    public uint Field45 { get; set; }
    public uint Field46 { get; set; }
    public ushort Field47 { get; set; }
    public uint Field48 { get; set; }
    public uint Field49 { get; set; }
    public uint Field50 { get; set; }
    public ushort Field51 { get; set; }
    public uint Field52 { get; set; }
    public ushort Field53 { get; set; }
    public uint Field54 { get; set; }
    public byte Field55 { get; set; }
    public ushort Field56 { get; set; }
    public uint Field57 { get; set; }
    public ushort Field58 { get; set; }
    public byte Field59 { get; set; }
    public byte Field60 { get; set; }
    public uint Field61 { get; set; }
    public byte Field62 { get; set; }
    public uint Field63 { get; set; }
    public byte Field64 { get; set; }
    public byte Field65 { get; set; }
    public uint Field66 { get; set; }
    public uint Field67 { get; set; }
    public uint Field68 { get; set; }
    public uint Field69 { get; set; }
    public uint Field70 { get; set; }
    public uint Field71 { get; set; }

    public ItemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadByte();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadUTF16UnicodeString();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadUInt32();
        Field28 = reader.ReadUInt32();
        Field29 = reader.ReadByte();
        Field30 = reader.ReadByte();
        Field31 = reader.ReadByte();
        Field32 = reader.ReadByte();
        Field33 = reader.ReadByte();
        Field34 = reader.ReadUInt32();
        Field35 = reader.ReadUInt32();
        Field36 = reader.ReadUInt32();
        Field37 = reader.ReadUInt32();
        Field38 = reader.ReadUInt32();
        Field39 = reader.ReadInt32();
        Field40 = reader.ReadInt32();
        Field41 = reader.ReadInt32();
        Field42 = reader.ReadInt32();
        Field43 = reader.ReadInt32();
        Field44 = reader.ReadUInt32();
        Field45 = reader.ReadUInt32();
        Field46 = reader.ReadUInt32();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadUInt32();
        Field49 = reader.ReadUInt32();
        Field50 = reader.ReadUInt32();
        Field51 = reader.ReadUInt16();
        Field52 = reader.ReadUInt32();
        Field53 = reader.ReadUInt16();
        Field54 = reader.ReadUInt32();
        Field55 = reader.ReadByte();
        Field56 = reader.ReadUInt16();
        Field57 = reader.ReadUInt32();
        Field58 = reader.ReadUInt16();
        Field59 = reader.ReadByte();
        Field60 = reader.ReadByte();
        Field61 = reader.ReadUInt32();
        Field62 = reader.ReadByte();
        Field63 = reader.ReadUInt32();
        Field64 = reader.ReadByte();
        Field65 = reader.ReadByte();
        Field66 = reader.ReadUInt32();
        Field67 = reader.ReadUInt32();
        Field68 = reader.ReadUInt32();
        Field69 = reader.ReadUInt32();
        Field70 = reader.ReadUInt32();
        Field71 = reader.ReadUInt32();
    }

    static string IEntry<ItemEntry>.TableName => TableName;

    static ItemEntry IEntry<ItemEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemEntry(reader);
    }
}
