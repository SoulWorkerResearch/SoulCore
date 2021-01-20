using SoulCore.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.KR.Entities
{
    using KeyType = UInt32;

    public sealed class KRTEItemCountBox : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public byte UsageCount { get; set; }
        public List<ushort> UsageGroup { get; set; }

        public KRTEItemCountBox(BinaryReader br)
        {
            Id = br.ReadUInt16();
            UsageCount = br.ReadByte();
            UsageGroup = br.ReadUInt16Enumerable(ItemsCount).ToList();
        }

        private const byte ItemsCount = 30;
    }
}