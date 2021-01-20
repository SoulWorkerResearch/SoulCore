using SoulCore.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.KR.Entities
{
    using KeyType = UInt32;

    public sealed class KRTEChattingCommand : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public byte PermissionLevel { get; set; }
        public List<string> Command { get; set; }
        public uint ActionType { get; set; }

        public KRTEChattingCommand(BinaryReader br)
        {
            Id = br.ReadUInt16();
            PermissionLevel = br.ReadByte();
            Command = br.ReadByteLengthUnicodeStringEnumerable(CommandsCount).ToList();
            ActionType = br.ReadUInt32();
        }

        private const byte CommandsCount = 5;
    }
}