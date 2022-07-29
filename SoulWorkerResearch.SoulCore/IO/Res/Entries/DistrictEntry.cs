global using DistrictKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record DistrictEntry : ITableEntry<DistrictKeyType>
{
    public const string TableName = "tb_district";

    public DistrictKeyType Id { get; }
    public ushort Unknown5 { get; }
    public ushort Unknown6 { get; }
    public ushort Unknown7 { get; }
    public string Unknown8 { get; }
    public string Batch { get; }
    public ushort Unknown10 { get; }
    public uint Unknown11 { get; }
    public uint Unknown12 { get; }
    public string Bgm { get; }
    public string Bg { get; }
    public byte Unknown15 { get; }
    public byte Unknown16 { get; }
    public string Map { get; }
    public byte Unknown18 { get; }
    public byte Unknown19 { get; }

    public DistrictEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Unknown5 = reader.ReadUInt16();
        Unknown6 = reader.ReadUInt16();
        Unknown7 = reader.ReadUInt16();
        Unknown8 = reader.ReadUTF16UnicodeString();
        Batch = reader.ReadUTF16UnicodeString();
        Unknown10 = reader.ReadUInt16();
        Unknown11 = reader.ReadUInt32();
        Unknown12 = reader.ReadUInt32();
        Bgm = reader.ReadUTF16UnicodeString();
        Bg = reader.ReadUTF16UnicodeString();
        Unknown15 = reader.ReadByte();
        Unknown16 = reader.ReadByte();
        Map = reader.ReadUTF16UnicodeString();
        Unknown18 = reader.ReadByte();
        Unknown19 = reader.ReadByte();
    }
}
