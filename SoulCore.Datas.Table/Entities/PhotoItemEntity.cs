using SoulCore.Extensions;
using SoulCore.Types;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_Photo_Item")]
    public sealed class PhotoItemEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; set; }
        public uint Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public string Unknown3 { get; set; }
        public string Unknown4 { get; set; }
        public string Unknown5 { get; set; }
        public string Unknown6 { get; set; }
        public string Unknown7 { get; set; }
        public string Unknown8 { get; set; }
        public string Unknown9 { get; set; }
        public string Unknown10 { get; set; }
        public string Unknown11 { get; set; }
        public string Unknown12 { get; set; }
        public Class Class { get; set; }
        public byte PromotionInfo { get; set; }

        public PhotoItemEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            Unknown1 = br.ReadUInt32();
            Unknown2 = br.ReadUInt16();
            Unknown3 = br.ReadCharacterLengthUnicodeString();
            Unknown4 = br.ReadCharacterLengthUnicodeString();
            Unknown5 = br.ReadCharacterLengthUnicodeString();
            Unknown6 = br.ReadCharacterLengthUnicodeString();
            Unknown7 = br.ReadCharacterLengthUnicodeString();
            Unknown8 = br.ReadCharacterLengthUnicodeString();
            Unknown9 = br.ReadCharacterLengthUnicodeString();
            Unknown10 = br.ReadCharacterLengthUnicodeString();
            Unknown11 = br.ReadCharacterLengthUnicodeString();
            Unknown12 = br.ReadCharacterLengthUnicodeString();
            Class = br.ReadClass();
            PromotionInfo = br.ReadByte();
        }
    }
}
