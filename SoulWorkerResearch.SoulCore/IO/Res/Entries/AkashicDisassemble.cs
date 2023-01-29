global using AkashicDisassembleKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AkashicDisassembleEntry : IEntry<AkashicDisassembleEntry>
{
    public const string TableName = "tb_Akashic_Disassemble";

    public AkashicDisassembleKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }

    public AkashicDisassembleEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
    }

    static string IEntry<AkashicDisassembleEntry>.TableName => TableName;

    static AkashicDisassembleEntry IEntry<AkashicDisassembleEntry>.CreateInstance(BinaryReader reader)
    {
        return new AkashicDisassembleEntry(reader);
    }
}
