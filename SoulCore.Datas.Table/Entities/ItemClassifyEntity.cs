using SoulCore.Extensions;
using SoulCore.Types;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_Item_Classify")]
    public sealed class ItemClassifyEntity : ITableEntity<KeyType>
    {
        public sealed class ActionInfo
        {
            public string Move { get; set; }
            public string Drop { get; set; }
            public string Equip { get; set; }
            public string Unequip { get; set; }

            public ActionInfo(BinaryReader br)
            {
                Move = br.ReadCharacterLengthUnicodeString();
                Drop = br.ReadCharacterLengthUnicodeString();
                Equip = br.ReadCharacterLengthUnicodeString();
                Unequip = br.ReadCharacterLengthUnicodeString();
            }
        }

        public KeyType Id { get; set; }
        public byte Group { get; set; }
        public ushort Unknown6 { get; set; }
        public byte SubGroup { get; set; }
        public ushort Unknown8 { get; set; }
        public byte Category { get; set; }
        public ushort Unknown10 { get; set; }
        public byte SubCategory { get; set; }
        public ushort Unknown12 { get; set; }
        public byte GainType { get; set; }
        public ItemClassifyInventoryType InventoryType { get; set; }
        public ItemClassifySlotType SlotType { get; set; }
        public byte RepairType { get; set; }
        public byte UseState { get; set; }
        public byte UseType { get; set; }
        public byte ConsumeType { get; set; }
        public ushort Unknown20 { get; set; }
        public ushort SocketId { get; set; }
        public ushort Unknown22 { get; set; }
        public ActionInfo Action { get; set; }
        public short Unknown27 { get; set; }

        public ItemClassifyEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            Group = br.ReadByte();
            Unknown6 = br.ReadUInt16();
            SubGroup = br.ReadByte();
            Unknown8 = br.ReadUInt16();
            Category = br.ReadByte();
            Unknown10 = br.ReadUInt16();
            SubCategory = br.ReadByte();
            Unknown12 = br.ReadUInt16();
            GainType = br.ReadByte();
            InventoryType = br.ReadItemClassifyInventoryType();
            SlotType = br.ReadItemClassifySlotType();
            RepairType = br.ReadByte();
            UseState = br.ReadByte();
            UseType = br.ReadByte();
            ConsumeType = br.ReadByte();
            Unknown20 = br.ReadUInt16();
            SocketId = br.ReadUInt16();
            Unknown22 = br.ReadUInt16();
            Action = new(br);
            Unknown27 = br.ReadInt16();
        }
    }
}
