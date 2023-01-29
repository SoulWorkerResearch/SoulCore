global using RandomGetGroupKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RandomGetGroupEntry : IEntry<RandomGetGroupEntry>
{
    public const string TableName = "tb_Random_Get_Group";

    public RandomGetGroupKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public ushort Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }

    public RandomGetGroupEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
    }

    static string IEntry<RandomGetGroupEntry>.TableName => TableName;

    static RandomGetGroupEntry IEntry<RandomGetGroupEntry>.CreateInstance(BinaryReader reader)
    {
        return new RandomGetGroupEntry(reader);
    }
}
