global using ModeCardmatchRuleKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeCardmatchRuleEntry : IEntry<ModeCardmatchRuleEntry>
{
    public const string TableName = "tb_Mode_CardMatch_Rule";

    public ModeCardmatchRuleKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public byte Field8 { get; set; }
    public ushort Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }

    public ModeCardmatchRuleEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
    }

    static string IEntry<ModeCardmatchRuleEntry>.TableName => TableName;

    static ModeCardmatchRuleEntry IEntry<ModeCardmatchRuleEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeCardmatchRuleEntry(reader);
    }
}
