using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.KR.Entities
{
    using KeyType = UInt32;

    [Table("tb_item_script")]
    public sealed class KRTEItemScript : ITableEntity<KeyType>
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

        public KRTEItemScript(BinaryReader br)
        {
            Id = br.ReadUInt32();
            Icon = br.ReadByteLengthUnicodeString();
            Unknown6 = br.ReadByteLengthUnicodeString();
            Unknown7 = br.ReadByteLengthUnicodeString();
            Unknown8 = br.ReadByteLengthUnicodeString();
            Unknown9 = br.ReadByteLengthUnicodeString();
            Unknown10 = br.ReadByteLengthUnicodeString();
            Unknown11 = br.ReadByte();
            Unknown12 = br.ReadByte();
            Unknown13 = br.ReadByte();
            Unknown14 = br.ReadByte();
            Unknown15 = br.ReadByte();
            Name = br.ReadByteLengthUnicodeString();
            Description = br.ReadByteLengthUnicodeString();
        }
    }
}