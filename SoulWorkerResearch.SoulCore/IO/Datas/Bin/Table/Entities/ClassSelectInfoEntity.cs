using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.Types;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table.Entities
{
    using KeyType = Class;

    [Table("tb_ClassSelect_Info")]
    public sealed class ClassSelectInfoEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; set; }
        public string Unknown5 { get; set; }
        public string Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint HandsFashionId { get; set; }
        public uint Unknown13 { get; set; }
        public uint OuterwearFashionId { get; set; }
        public uint Unknown15 { get; set; }
        public uint StockingsFashionId { get; set; }
        public uint ShoesFashionId { get; set; }
        public uint Unknown18 { get; set; }
        public uint Unknown19 { get; set; }
        public ushort Unknown20 { get; set; }
        public ushort Unknown21 { get; set; }
        public int Unknown22 { get; set; }
        public ushort Unknown23 { get; set; }
        public string Unknown24 { get; set; }
        public string Unknown25 { get; set; }
        public string Unknown26 { get; set; }
        public string Unknown27 { get; set; }
        public string Unknown28 { get; set; }
        public string Unknown29 { get; set; }

        public ClassSelectInfoEntity(BinaryReader br)
        {
            Id = br.ReadClass();
            Unknown5 = br.ReadCharacterLengthUnicodeString();
            Unknown6 = br.ReadCharacterLengthUnicodeString();
            Unknown7 = br.ReadUInt32();
            Unknown8 = br.ReadUInt32();
            Unknown9 = br.ReadUInt32();
            Unknown10 = br.ReadUInt32();
            Unknown11 = br.ReadUInt32();
            HandsFashionId = br.ReadUInt32();
            Unknown13 = br.ReadUInt32();
            OuterwearFashionId = br.ReadUInt32();
            Unknown15 = br.ReadUInt32();
            StockingsFashionId = br.ReadUInt32();
            ShoesFashionId = br.ReadUInt32();
            Unknown18 = br.ReadUInt32();
            Unknown19 = br.ReadUInt32();
            Unknown20 = br.ReadUInt16();
            Unknown21 = br.ReadUInt16();
            Unknown22 = br.ReadInt32();
            Unknown23 = br.ReadUInt16();
            Unknown24 = br.ReadCharacterLengthUnicodeString();
            Unknown25 = br.ReadCharacterLengthUnicodeString();
            Unknown26 = br.ReadCharacterLengthUnicodeString();
            Unknown27 = br.ReadCharacterLengthUnicodeString();
            Unknown28 = br.ReadCharacterLengthUnicodeString();
            Unknown29 = br.ReadCharacterLengthUnicodeString();
        }
    }
}
