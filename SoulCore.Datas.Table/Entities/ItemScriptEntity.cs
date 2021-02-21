using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_item_script")]
    public sealed class ItemScriptEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public string Icon { get; set; }
        public string Unknown6 { get; set; }
        public string Unknown7 { get; set; }
        public string Unknown8 { get; set; }
        public string Unknown9 { get; set; }
        public string Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemScriptEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            Icon = br.ReadCharacterLengthUnicodeString();
            Unknown6 = br.ReadCharacterLengthUnicodeString();
            Unknown7 = br.ReadCharacterLengthUnicodeString();
            Unknown8 = br.ReadCharacterLengthUnicodeString();
            Unknown9 = br.ReadCharacterLengthUnicodeString();
            Unknown10 = br.ReadCharacterLengthUnicodeString();
            Unknown11 = br.ReadByte();
            Unknown12 = br.ReadByte();
            Unknown13 = br.ReadByte();
            Unknown14 = br.ReadByte();
            Unknown15 = br.ReadByte();
            Name = br.ReadCharacterLengthUnicodeString();
            Description = br.ReadCharacterLengthUnicodeString();
        }
    }
}
