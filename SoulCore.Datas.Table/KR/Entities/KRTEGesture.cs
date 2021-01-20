﻿using SoulCore.Extensions;
using SoulCore.Type;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.KR.Entities
{
    using KeyType = UInt16;

    [Table("tb_Gesture")]
    public sealed class KRTEGesture : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public Class Class { get; set; }
        public byte MinLevel { get; set; }
        public byte InitialGesture { get; set; }
        public uint CoolTime { get; set; }
        public ushort Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public string Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public string Unknown13 { get; set; }
        public string Unknown14 { get; set; }
        public string Unknown15 { get; set; }
        public uint Unknown16 { get; set; }
        public ushort Unknown17 { get; set; }
        public ushort Unknown18 { get; set; }

        public KRTEGesture(BinaryReader br)
        {
            Id = br.ReadUInt16();
            Class = br.ReadClass();
            MinLevel = br.ReadByte();
            InitialGesture = br.ReadByte();
            CoolTime = br.ReadUInt32();
            Unknown5 = br.ReadUInt16();
            Unknown6 = br.ReadUInt32();
            Unknown7 = br.ReadByteLengthUnicodeString();
            Unknown8 = br.ReadByte();
            Unknown9 = br.ReadUInt32();
            Unknown10 = br.ReadUInt32();
            Unknown11 = br.ReadUInt32();
            Unknown12 = br.ReadUInt32();
            Unknown13 = br.ReadByteLengthUnicodeString();
            Unknown14 = br.ReadByteLengthUnicodeString();
            Unknown15 = br.ReadByteLengthUnicodeString();
            Unknown16 = br.ReadUInt32();
            Unknown17 = br.ReadUInt16();
            Unknown18 = br.ReadUInt16();
        }
    }
}