global using DistrictKeyType = System.Int16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DistrictEntry : IEntry<DistrictEntry>
{
    public const string TableName = "tb_district";

    public DistrictKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public ushort Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public string Field9 { get; set; } = string.Empty;
    public string Field10 { get; set; } = string.Empty;
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public string Field13 { get; set; } = string.Empty;
    public byte Field14 { get; set; }
    public byte Field15 { get; set; }

    public DistrictEntry(BinaryReader reader)
    {
        Id = reader.ReadInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadByte();
    }

    static string IEntry<DistrictEntry>.TableName => TableName;

    static DistrictEntry IEntry<DistrictEntry>.CreateInstance(BinaryReader reader)
    {
        return new DistrictEntry(reader);
    }
}
