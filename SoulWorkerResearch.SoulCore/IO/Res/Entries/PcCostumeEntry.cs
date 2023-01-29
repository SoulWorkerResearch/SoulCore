global using PcCostumeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PcCostumeEntry : IEntry<PcCostumeEntry>
{
    public const string TableName = "tb_PC_Costume";

    public PcCostumeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }

    public PcCostumeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
    }

    static string IEntry<PcCostumeEntry>.TableName => TableName;

    static PcCostumeEntry IEntry<PcCostumeEntry>.CreateInstance(BinaryReader reader)
    {
        return new PcCostumeEntry(reader);
    }
}
