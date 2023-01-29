global using WorldEventRewardKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class WorldEventRewardEntry : IEntry<WorldEventRewardEntry>
{
    public const string TableName = "tb_world_event_reward";

    public WorldEventRewardKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }
    public ushort Field6 { get; set; }

    public WorldEventRewardEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt16();
    }

    static string IEntry<WorldEventRewardEntry>.TableName => TableName;

    static WorldEventRewardEntry IEntry<WorldEventRewardEntry>.CreateInstance(BinaryReader reader)
    {
        return new WorldEventRewardEntry(reader);
    }
}
