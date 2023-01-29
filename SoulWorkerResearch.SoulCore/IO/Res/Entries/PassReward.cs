global using PassRewardKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PassRewardEntry : IEntry<PassRewardEntry>
{
    public const string TableName = "tb_Pass_Reward";

    public PassRewardKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public ushort Field5 { get; set; }
    public uint Field6 { get; set; }
    public ushort Field7 { get; set; }

    public PassRewardEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt16();
    }

    static string IEntry<PassRewardEntry>.TableName => TableName;

    static PassRewardEntry IEntry<PassRewardEntry>.CreateInstance(BinaryReader reader)
    {
        return new PassRewardEntry(reader);
    }
}
