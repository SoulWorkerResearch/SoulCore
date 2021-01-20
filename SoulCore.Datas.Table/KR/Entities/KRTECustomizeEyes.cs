using SoulCore.Extensions;
using SoulCore.Type;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.KR.Entities
{
    using KeyType = Class;

    [Table("tb_Customize_Eyes")]
    public sealed class KRTECustomizeEyes : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public List<uint> Unknown1 { get; set; }
        public List<string> Icons { get; set; }
        public List<uint> Color { get; set; }

        public KRTECustomizeEyes(BinaryReader br)
        {
            Id = br.ReadClass();
            Unknown1 = br.ReadUInt32Enumerable(ItemsCount).ToList();
            Icons = br.ReadByteLengthUnicodeStringEnumerable(ItemsCount).ToList();
            Color = br.ReadUInt32Enumerable(ItemsCount).ToList();
        }

        private const byte ItemsCount = 10;
    }
}