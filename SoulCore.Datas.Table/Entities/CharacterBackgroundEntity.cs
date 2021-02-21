using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_Character_Background")]
    public sealed class CharacterBackgroundEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public ushort Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public string Unknown4 { get; set; }

        public CharacterBackgroundEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            Unknown1 = br.ReadUInt16();
            Unknown2 = br.ReadUInt16();
            Unknown3 = br.ReadUInt16();
            Unknown4 = br.ReadCharacterLengthUnicodeString();
        }
    }
}
