global using HelperRewardKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class HelperRewardEntry : IEntry<HelperRewardEntry>
{
    public const string TableName = "tb_Helper_Reward";

    public HelperRewardKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }

    public HelperRewardEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
    }

    static string IEntry<HelperRewardEntry>.TableName => TableName;

    static HelperRewardEntry IEntry<HelperRewardEntry>.CreateInstance(BinaryReader reader)
    {
        return new HelperRewardEntry(reader);
    }
}
