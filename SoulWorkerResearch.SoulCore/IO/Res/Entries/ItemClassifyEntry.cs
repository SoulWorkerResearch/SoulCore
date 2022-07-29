global using ItemClassifyKeyType = System.UInt32;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed partial record ItemClassifyEntry : ITableEntry<ItemClassifyKeyType>
{
    public const string TableName = "tb_Item_Classify";

    public sealed record ActionInfo(string Move, string Drop, string Equip, string Unequip);

    public ItemClassifyKeyType Id { get; }
    public byte Group { get; }
    public ushort Unknown6 { get; }
    public byte SubGroup { get; }
    public ushort Unknown8 { get; }
    public byte Category { get; }
    public ushort Unknown10 { get; }
    public byte SubCategory { get; }
    public ushort Unknown12 { get; }
    public byte GainType { get; }
    public ItemClassifyInventoryType InventoryType { get; }
    public ItemClassifySlotType SlotType { get; }
    public byte RepairType { get; }
    public byte UseState { get; }
    public byte UseType { get; }
    public byte ConsumeType { get; }
    public ushort Unknown20 { get; }
    public ushort SocketId { get; }
    public ushort Unknown22 { get; }
    public ActionInfo Action { get; }
    public short Unknown27 { get; }

    public ItemClassifyEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Group = reader.ReadByte();
        Unknown6 = reader.ReadUInt16();
        SubGroup = reader.ReadByte();
        Unknown8 = reader.ReadUInt16();
        Category = reader.ReadByte();
        Unknown10 = reader.ReadUInt16();
        SubCategory = reader.ReadByte();
        Unknown12 = reader.ReadUInt16();
        GainType = reader.ReadByte();
        InventoryType = reader.ReadItemClassifyInventoryType();
        SlotType = reader.ReadItemClassifySlotType();
        RepairType = reader.ReadByte();
        UseState = reader.ReadByte();
        UseType = reader.ReadByte();
        ConsumeType = reader.ReadByte();
        Unknown20 = reader.ReadUInt16();
        SocketId = reader.ReadUInt16();
        Unknown22 = reader.ReadUInt16();

        Action = new(
            reader.ReadUTF16UnicodeString(),
            reader.ReadUTF16UnicodeString(),
            reader.ReadUTF16UnicodeString(),
            reader.ReadUTF16UnicodeString());

        Unknown27 = reader.ReadInt16();
    }
}
