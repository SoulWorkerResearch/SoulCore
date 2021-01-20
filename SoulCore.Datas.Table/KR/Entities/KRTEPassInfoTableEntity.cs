﻿using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.KR.Entities
{
    using KeyType = UInt32;

    [Table("tb_Pass_Info")]
    public sealed class KRTEPassInfoTableEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public uint v6 { get; set; }
        public byte v7 { get; set; }
        public uint v8 { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public byte v11 { get; set; }
        public string Cover { get; set; }
        public string ItemIcon { get; set; }
        public uint v14 { get; set; }

        public KRTEPassInfoTableEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            v6 = br.ReadUInt32();
            v7 = br.ReadByte();
            v8 = br.ReadUInt32();
            StartDate = br.ReadByteLengthUnicodeString();
            EndDate = br.ReadByteLengthUnicodeString();
            v11 = br.ReadByte();
            Cover = br.ReadByteLengthUnicodeString();
            ItemIcon = br.ReadByteLengthUnicodeString();
            v14 = br.ReadUInt32();
        }
    }
}