global using DiceRewardKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DiceRewardEntry : IEntry<DiceRewardEntry>
{
    public const string TableName = "tb_Dice_Reward";

    public DiceRewardKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public uint Field5 { get; set; }
    public ushort Field6 { get; set; }

    public DiceRewardEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt16();
    }

    static string IEntry<DiceRewardEntry>.TableName => TableName;

    static DiceRewardEntry IEntry<DiceRewardEntry>.CreateInstance(BinaryReader reader)
    {
        return new DiceRewardEntry(reader);
    }
}
