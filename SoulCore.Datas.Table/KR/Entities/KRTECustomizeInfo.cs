using SoulCore.Extensions;
using SoulCore.Type;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.KR.Entities
{
    using KeyType = Class;

    [Table("tb_Customize_Info")]
    public sealed class KRTECustomizeInfo : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public byte Unknown1 { get; set; }
        public List<byte> Unknown2 { get; set; }
        public List<byte> Unknown3 { get; set; }
        public List<string> Unknown4 { get; set; }

        public KRTECustomizeInfo(BinaryReader br)
        {
            Id = br.ReadClass();
            Unknown1 = br.ReadByte();
            Unknown2 = br.ReadByteEnumerable(ItemsCount).ToList();
            Unknown3 = br.ReadByteEnumerable(ItemsCount).ToList();
            Unknown4 = br.ReadByteLengthUnicodeStringEnumerable(ItemsCount).ToList();
        }

        private const byte ItemsCount = 5;
    }
}