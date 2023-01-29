global using EqualizerSummonKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class EqualizerSummonEntry : IEntry<EqualizerSummonEntry>
{
    public const string TableName = "tb_Equalizer_Summon";

    public EqualizerSummonKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }

    public EqualizerSummonEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
    }

    static string IEntry<EqualizerSummonEntry>.TableName => TableName;

    static EqualizerSummonEntry IEntry<EqualizerSummonEntry>.CreateInstance(BinaryReader reader)
    {
        return new EqualizerSummonEntry(reader);
    }
}
