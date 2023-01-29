global using ItemClassifyKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemClassifyEntry : IEntry<ItemClassifyEntry>
{
    public const string TableName = "tb_Item_Classify";

    public ItemClassifyKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public byte Field5 { get; set; }
    public ushort Field6 { get; set; }
    public byte Field7 { get; set; }
    public ushort Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public byte Field14 { get; set; }
    public byte Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public string Field19 { get; set; } = string.Empty;
    public string Field20 { get; set; } = string.Empty;
    public string Field21 { get; set; } = string.Empty;
    public string Field22 { get; set; } = string.Empty;
    public short Field23 { get; set; }

    public ItemClassifyEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadUTF16UnicodeString();
        Field20 = reader.ReadUTF16UnicodeString();
        Field21 = reader.ReadUTF16UnicodeString();
        Field22 = reader.ReadUTF16UnicodeString();
        Field23 = reader.ReadInt16();
    }

    static string IEntry<ItemClassifyEntry>.TableName => TableName;

    static ItemClassifyEntry IEntry<ItemClassifyEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemClassifyEntry(reader);
    }
}
