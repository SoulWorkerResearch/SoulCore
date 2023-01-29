global using ItemInformationKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemInformationEntry : IEntry<ItemInformationEntry>
{
    public const string TableName = "tb_item_information";

    public ItemInformationKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }

    public ItemInformationEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
    }

    static string IEntry<ItemInformationEntry>.TableName => TableName;

    static ItemInformationEntry IEntry<ItemInformationEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemInformationEntry(reader);
    }
}
