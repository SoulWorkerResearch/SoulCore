global using ItemModelKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemModelEntry : IEntry<ItemModelEntry>
{
    public const string TableName = "tb_item_model";

    public ItemModelKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public short Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public string Field8 { get; set; } = string.Empty;
    public byte Field9 { get; set; }

    public ItemModelEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadByte();
    }

    static string IEntry<ItemModelEntry>.TableName => TableName;

    static ItemModelEntry IEntry<ItemModelEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemModelEntry(reader);
    }
}
