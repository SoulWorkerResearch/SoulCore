global using RankInfoKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RankInfoEntry : IEntry<RankInfoEntry>
{
    public const string TableName = "tb_Rank_Info";

    public RankInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public ushort Field5 { get; set; }
    public byte Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public byte Field9 { get; set; }
    public string Field10 { get; set; } = string.Empty;
    public uint Field11 { get; set; }

    public RankInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadUInt32();
    }

    static string IEntry<RankInfoEntry>.TableName => TableName;

    static RankInfoEntry IEntry<RankInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new RankInfoEntry(reader);
    }
}
