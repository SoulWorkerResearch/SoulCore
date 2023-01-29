global using RandomChangeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RandomChangeEntry : IEntry<RandomChangeEntry>
{
    public const string TableName = "tb_Random_Change";

    public RandomChangeKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public ushort Field8 { get; set; }

    public RandomChangeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUInt16();
    }

    static string IEntry<RandomChangeEntry>.TableName => TableName;

    static RandomChangeEntry IEntry<RandomChangeEntry>.CreateInstance(BinaryReader reader)
    {
        return new RandomChangeEntry(reader);
    }
}
