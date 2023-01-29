global using RoomrankRewardKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RoomrankRewardEntry : IEntry<RoomrankRewardEntry>
{
    public const string TableName = "tb_RoomRank_Reward";

    public RoomrankRewardKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }

    public RoomrankRewardEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
    }

    static string IEntry<RoomrankRewardEntry>.TableName => TableName;

    static RoomrankRewardEntry IEntry<RoomrankRewardEntry>.CreateInstance(BinaryReader reader)
    {
        return new RoomrankRewardEntry(reader);
    }
}
