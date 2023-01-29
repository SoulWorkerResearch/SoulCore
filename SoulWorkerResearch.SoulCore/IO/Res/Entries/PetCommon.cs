global using PetCommonKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetCommonEntry : IEntry<PetCommonEntry>
{
    public const string TableName = "tb_Pet_Common";

    public PetCommonKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }

    public PetCommonEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
    }

    static string IEntry<PetCommonEntry>.TableName => TableName;

    static PetCommonEntry IEntry<PetCommonEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetCommonEntry(reader);
    }
}
