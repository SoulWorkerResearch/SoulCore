global using PetItemCombinationKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetItemCombinationEntry : IEntry<PetItemCombinationEntry>
{
    public const string TableName = "tb_Pet_Item_Combination";

    public PetItemCombinationKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }

    public PetItemCombinationEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
    }

    static string IEntry<PetItemCombinationEntry>.TableName => TableName;

    static PetItemCombinationEntry IEntry<PetItemCombinationEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetItemCombinationEntry(reader);
    }
}
