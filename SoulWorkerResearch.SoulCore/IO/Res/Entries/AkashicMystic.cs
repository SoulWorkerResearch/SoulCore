global using AkashicMysticKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AkashicMysticEntry : IEntry<AkashicMysticEntry>
{
    public const string TableName = "tb_Akashic_Mystic";

    public AkashicMysticKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }

    public AkashicMysticEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
    }

    static string IEntry<AkashicMysticEntry>.TableName => TableName;

    static AkashicMysticEntry IEntry<AkashicMysticEntry>.CreateInstance(BinaryReader reader)
    {
        return new AkashicMysticEntry(reader);
    }
}
