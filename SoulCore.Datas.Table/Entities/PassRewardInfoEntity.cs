using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_Pass_Reward")]
    public sealed class PassRewardInfoEntity : ITableEntity<KeyType>
    {
        public sealed class ItemInfo
        {
            public uint Id { get; set; }
            public ushort Count { get; set; }

            public ItemInfo(BinaryReader br) => (Id, Count) = (br.ReadUInt32(), br.ReadUInt16());
        }

        public sealed class ItemsInfo
        {
            public ItemInfo Slave { get; set; }
            public ItemInfo Premium { get; set; }

            public ItemsInfo(BinaryReader br) => (Slave, Premium) = (new(br), new(br));
        }

        public KeyType Id { get; set; }
        public uint PassInfo { get; set; }
        public byte SequenceId { get; set; }
        public uint PointRequired { get; set; }
        public ItemsInfo RewardItem { get; set; }

        public PassRewardInfoEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            PassInfo = br.ReadUInt32();
            SequenceId = br.ReadByte();
            PointRequired = br.ReadUInt32();
            RewardItem = new(br);
        }
    }
}
