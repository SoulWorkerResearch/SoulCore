using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt16;

    [Table("tb_district")]
    public sealed class DistrictEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public ushort Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public ushort Unknown7 { get; set; }
        public string Unknown8 { get; set; }
        public string Batch { get; set; }
        public ushort Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public string Bgm { get; set; }
        public string Bg { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public string Map { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }

        public DistrictEntity(BinaryReader br)
        {
            Id = br.ReadUInt16();
            Unknown5 = br.ReadUInt16();
            Unknown6 = br.ReadUInt16();
            Unknown7 = br.ReadUInt16();
            Unknown8 = br.ReadByteLengthUnicodeString();
            Batch = br.ReadByteLengthUnicodeString();
            Unknown10 = br.ReadUInt16();
            Unknown11 = br.ReadUInt32();
            Unknown12 = br.ReadUInt32();
            Bgm = br.ReadByteLengthUnicodeString();
            Bg = br.ReadByteLengthUnicodeString();
            Unknown15 = br.ReadByte();
            Unknown16 = br.ReadByte();
            Map = br.ReadByteLengthUnicodeString();
            Unknown18 = br.ReadByte();
            Unknown19 = br.ReadByte();
        }
    }
}
