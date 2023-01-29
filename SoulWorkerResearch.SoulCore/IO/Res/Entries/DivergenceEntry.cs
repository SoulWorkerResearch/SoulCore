global using DivergenceKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DivergenceEntry : IEntry<DivergenceEntry>
{
    public const string TableName = "tb_Divergence";

    public DivergenceKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public ushort Field9 { get; set; }
    public byte Field10 { get; set; }
    public string Field11 { get; set; } = string.Empty;
    public byte Field12 { get; set; }
    public uint Field13 { get; set; }
    public float Field14 { get; set; }

    public DivergenceEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadSingle();
    }

    static string IEntry<DivergenceEntry>.TableName => TableName;

    static DivergenceEntry IEntry<DivergenceEntry>.CreateInstance(BinaryReader reader)
    {
        return new DivergenceEntry(reader);
    }
}
