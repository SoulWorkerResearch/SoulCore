global using PcAkashicKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PcAkashicEntry : IEntry<PcAkashicEntry>
{
    public const string TableName = "tb_PC_Akashic";

    public PcAkashicKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }

    public PcAkashicEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
    }

    static string IEntry<PcAkashicEntry>.TableName => TableName;

    static PcAkashicEntry IEntry<PcAkashicEntry>.CreateInstance(BinaryReader reader)
    {
        return new PcAkashicEntry(reader);
    }
}
