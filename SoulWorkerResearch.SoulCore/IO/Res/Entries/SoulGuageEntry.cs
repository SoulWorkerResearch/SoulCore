global using SoulGuageKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SoulGuageEntry : IEntry<SoulGuageEntry>
{
    public const string TableName = "tb_Soul_Guage";

    public SoulGuageKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }

    public SoulGuageEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
    }

    static string IEntry<SoulGuageEntry>.TableName => TableName;

    static SoulGuageEntry IEntry<SoulGuageEntry>.CreateInstance(BinaryReader reader)
    {
        return new SoulGuageEntry(reader);
    }
}
