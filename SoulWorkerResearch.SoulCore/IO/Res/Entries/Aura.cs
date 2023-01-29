global using AuraKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AuraEntry : IEntry<AuraEntry>
{
    public const string TableName = "tb_Aura";

    public AuraKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }

    public AuraEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
    }

    static string IEntry<AuraEntry>.TableName => TableName;

    static AuraEntry IEntry<AuraEntry>.CreateInstance(BinaryReader reader)
    {
        return new AuraEntry(reader);
    }
}
