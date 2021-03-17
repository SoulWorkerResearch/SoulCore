using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_Pass_Info")]
    public sealed class PassInfoEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; set; }
        public uint v6 { get; set; }
        public byte v7 { get; set; }
        public uint v8 { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public byte v11 { get; set; }
        public string Cover { get; set; }
        public string ItemIcon { get; set; }
        public uint v14 { get; set; }

        public PassInfoEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            v6 = br.ReadUInt32();
            v7 = br.ReadByte();
            v8 = br.ReadUInt32();
            StartDate = br.ReadCharacterLengthUnicodeString();
            EndDate = br.ReadCharacterLengthUnicodeString();
            v11 = br.ReadByte();
            Cover = br.ReadCharacterLengthUnicodeString();
            ItemIcon = br.ReadCharacterLengthUnicodeString();
            v14 = br.ReadUInt32();
        }
    }
}
