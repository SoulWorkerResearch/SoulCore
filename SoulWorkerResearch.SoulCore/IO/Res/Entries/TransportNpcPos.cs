global using TransportNpcPosKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class TransportNpcPosEntry : IEntry<TransportNpcPosEntry>
{
    public const string TableName = "tb_Transport_NPC_Pos";

    public TransportNpcPosKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }

    public TransportNpcPosEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
    }

    static string IEntry<TransportNpcPosEntry>.TableName => TableName;

    static TransportNpcPosEntry IEntry<TransportNpcPosEntry>.CreateInstance(BinaryReader reader)
    {
        return new TransportNpcPosEntry(reader);
    }
}
