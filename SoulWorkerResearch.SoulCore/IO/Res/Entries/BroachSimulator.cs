global using BroachSimulatorKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BroachSimulatorEntry : IEntry<BroachSimulatorEntry>
{
    public const string TableName = "tb_broach_Simulator";

    public BroachSimulatorKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }

    public BroachSimulatorEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
    }

    static string IEntry<BroachSimulatorEntry>.TableName => TableName;

    static BroachSimulatorEntry IEntry<BroachSimulatorEntry>.CreateInstance(BinaryReader reader)
    {
        return new BroachSimulatorEntry(reader);
    }
}
