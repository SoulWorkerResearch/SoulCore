global using ReinforceExchangeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ReinforceExchangeEntry : IEntry<ReinforceExchangeEntry>
{
    public const string TableName = "tb_Reinforce_Exchange";

    public ReinforceExchangeKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public byte Field5 { get; set; }

    public ReinforceExchangeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadByte();
    }

    static string IEntry<ReinforceExchangeEntry>.TableName => TableName;

    static ReinforceExchangeEntry IEntry<ReinforceExchangeEntry>.CreateInstance(BinaryReader reader)
    {
        return new ReinforceExchangeEntry(reader);
    }
}
