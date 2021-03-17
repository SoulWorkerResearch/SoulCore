using SoulCore.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    public sealed class ChattingCommandEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; set; }
        public byte PermissionLevel { get; set; }
        public List<string> Command { get; set; }
        public uint ActionType { get; set; }

        public ChattingCommandEntity(BinaryReader br)
        {
            Id = br.ReadUInt16();
            PermissionLevel = br.ReadByte();
            Command = br.ReadByteLengthUnicodeStringEnumerable(CommandsCount).ToList();
            ActionType = br.ReadUInt32();
        }

        private const byte CommandsCount = 5;
    }
}