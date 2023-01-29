global using ItemSetitemKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemSetitemEntry : IEntry<ItemSetitemEntry>
{
    public const string TableName = "tb_Item_SetItem";

    public ItemSetitemKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public float Field19 { get; set; }
    public float Field20 { get; set; }
    public float Field21 { get; set; }
    public float Field22 { get; set; }
    public float Field23 { get; set; }
    public byte Field24 { get; set; }
    public byte Field25 { get; set; }
    public byte Field26 { get; set; }
    public byte Field27 { get; set; }
    public byte Field28 { get; set; }
    public ushort Field29 { get; set; }
    public ushort Field30 { get; set; }
    public ushort Field31 { get; set; }
    public ushort Field32 { get; set; }
    public ushort Field33 { get; set; }
    public float Field34 { get; set; }
    public float Field35 { get; set; }
    public float Field36 { get; set; }
    public float Field37 { get; set; }
    public float Field38 { get; set; }
    public byte Field39 { get; set; }
    public byte Field40 { get; set; }
    public byte Field41 { get; set; }
    public byte Field42 { get; set; }
    public byte Field43 { get; set; }
    public ushort Field44 { get; set; }
    public ushort Field45 { get; set; }
    public ushort Field46 { get; set; }
    public ushort Field47 { get; set; }
    public ushort Field48 { get; set; }
    public float Field49 { get; set; }
    public float Field50 { get; set; }
    public float Field51 { get; set; }
    public float Field52 { get; set; }
    public float Field53 { get; set; }
    public byte Field54 { get; set; }
    public byte Field55 { get; set; }
    public byte Field56 { get; set; }
    public byte Field57 { get; set; }
    public byte Field58 { get; set; }
    public ushort Field59 { get; set; }
    public ushort Field60 { get; set; }
    public ushort Field61 { get; set; }
    public ushort Field62 { get; set; }
    public ushort Field63 { get; set; }
    public float Field64 { get; set; }
    public float Field65 { get; set; }
    public float Field66 { get; set; }
    public float Field67 { get; set; }
    public float Field68 { get; set; }

    public ItemSetitemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadSingle();
        Field20 = reader.ReadSingle();
        Field21 = reader.ReadSingle();
        Field22 = reader.ReadSingle();
        Field23 = reader.ReadSingle();
        Field24 = reader.ReadByte();
        Field25 = reader.ReadByte();
        Field26 = reader.ReadByte();
        Field27 = reader.ReadByte();
        Field28 = reader.ReadByte();
        Field29 = reader.ReadUInt16();
        Field30 = reader.ReadUInt16();
        Field31 = reader.ReadUInt16();
        Field32 = reader.ReadUInt16();
        Field33 = reader.ReadUInt16();
        Field34 = reader.ReadSingle();
        Field35 = reader.ReadSingle();
        Field36 = reader.ReadSingle();
        Field37 = reader.ReadSingle();
        Field38 = reader.ReadSingle();
        Field39 = reader.ReadByte();
        Field40 = reader.ReadByte();
        Field41 = reader.ReadByte();
        Field42 = reader.ReadByte();
        Field43 = reader.ReadByte();
        Field44 = reader.ReadUInt16();
        Field45 = reader.ReadUInt16();
        Field46 = reader.ReadUInt16();
        Field47 = reader.ReadUInt16();
        Field48 = reader.ReadUInt16();
        Field49 = reader.ReadSingle();
        Field50 = reader.ReadSingle();
        Field51 = reader.ReadSingle();
        Field52 = reader.ReadSingle();
        Field53 = reader.ReadSingle();
        Field54 = reader.ReadByte();
        Field55 = reader.ReadByte();
        Field56 = reader.ReadByte();
        Field57 = reader.ReadByte();
        Field58 = reader.ReadByte();
        Field59 = reader.ReadUInt16();
        Field60 = reader.ReadUInt16();
        Field61 = reader.ReadUInt16();
        Field62 = reader.ReadUInt16();
        Field63 = reader.ReadUInt16();
        Field64 = reader.ReadSingle();
        Field65 = reader.ReadSingle();
        Field66 = reader.ReadSingle();
        Field67 = reader.ReadSingle();
        Field68 = reader.ReadSingle();
    }

    static string IEntry<ItemSetitemEntry>.TableName => TableName;

    static ItemSetitemEntry IEntry<ItemSetitemEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemSetitemEntry(reader);
    }
}
