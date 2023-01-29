global using AkashicCombinationKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AkashicCombinationEntry : IEntry<AkashicCombinationEntry>
{
    public const string TableName = "tb_Akashic_Combination";

    public AkashicCombinationKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public uint Field3 { get; set; }

    public AkashicCombinationEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt32();
    }

    static string IEntry<AkashicCombinationEntry>.TableName => TableName;

    static AkashicCombinationEntry IEntry<AkashicCombinationEntry>.CreateInstance(BinaryReader reader)
    {
        return new AkashicCombinationEntry(reader);
    }
}
