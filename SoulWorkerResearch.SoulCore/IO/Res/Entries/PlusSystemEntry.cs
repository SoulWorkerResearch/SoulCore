global using PlusSystemKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PlusSystemEntry : IEntry<PlusSystemEntry>
{
    public const string TableName = "tb_PLUS_System";

    public PlusSystemKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public ushort Field3 { get; set; }
    public uint Field4 { get; set; }

    public PlusSystemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt32();
    }

    static string IEntry<PlusSystemEntry>.TableName => TableName;

    static PlusSystemEntry IEntry<PlusSystemEntry>.CreateInstance(BinaryReader reader)
    {
        return new PlusSystemEntry(reader);
    }
}
