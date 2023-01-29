global using GachaKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GachaEntry : IEntry<GachaEntry>
{
    public const string TableName = "tb_Gacha";

    public GachaKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public ushort Field4 { get; set; }
    public uint Field5 { get; set; }
    public byte Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;
    public uint Field9 { get; set; }
    public ushort Field10 { get; set; }
    public ushort Field11 { get; set; }
    public ushort Field12 { get; set; }
    public string Field13 { get; set; } = string.Empty;

    public GachaEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<GachaEntry>.TableName => TableName;

    static GachaEntry IEntry<GachaEntry>.CreateInstance(BinaryReader reader)
    {
        return new GachaEntry(reader);
    }
}
