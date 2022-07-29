global using PassRewardInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed partial record PassRewardInfoEntry : ITableEntry<PassRewardInfoKeyType>
{
    public const string TableName = "tb_Pass_Reward";

    public sealed record ItemInfo(uint Id, ushort Count);
    public sealed record Item(ItemInfo Slave, ItemInfo Premium);

    public PassRewardInfoKeyType Id { get; }
    public uint PassInfo { get; }
    public byte SequenceId { get; }
    public uint PointRequired { get; }
    public Item RewardItem { get; }

    public PassRewardInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        PassInfo = reader.ReadUInt32();
        SequenceId = reader.ReadByte();
        PointRequired = reader.ReadUInt32();
        RewardItem = new(new(reader.ReadUInt32(), reader.ReadUInt16()), new(reader.ReadUInt32(), reader.ReadUInt16()));
    }
}
