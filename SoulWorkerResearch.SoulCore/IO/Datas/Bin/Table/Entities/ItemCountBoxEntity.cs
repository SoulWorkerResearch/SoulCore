using SoulWorkerResearch.SoulCore.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table.Entities
{
    using KeyType = UInt32;

    public sealed class ItemCountBoxEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; set; }
        public byte UsageCount { get; set; }
        public List<ushort> UsageGroup { get; set; }

        public ItemCountBoxEntity(BinaryReader br)
        {
            Id = br.ReadUInt16();
            UsageCount = br.ReadByte();
            UsageGroup = br.ReadUInt16Enumerable(ItemsCount).ToList();
        }

        private const byte ItemsCount = 30;
    }
}
