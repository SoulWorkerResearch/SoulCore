global using PcRewardSystemKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PcRewardSystemEntry : IEntry<PcRewardSystemEntry>
{
    public const string TableName = "tb_PC_Reward_System";

    public PcRewardSystemKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }
    public uint Field6 { get; set; }
    public short Field7 { get; set; }
    public short Field8 { get; set; }
    public short Field9 { get; set; }
    public short Field10 { get; set; }
    public short Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public uint Field15 { get; set; }
    public uint Field16 { get; set; }

    public PcRewardSystemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadInt16();
        Field8 = reader.ReadInt16();
        Field9 = reader.ReadInt16();
        Field10 = reader.ReadInt16();
        Field11 = reader.ReadInt16();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadUInt32();
        Field16 = reader.ReadUInt32();
    }

    static string IEntry<PcRewardSystemEntry>.TableName => TableName;

    static PcRewardSystemEntry IEntry<PcRewardSystemEntry>.CreateInstance(BinaryReader reader)
    {
        return new PcRewardSystemEntry(reader);
    }
}
