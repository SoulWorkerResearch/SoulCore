global using TransportInfoKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class TransportInfoEntry : IEntry<TransportInfoEntry>
{
    public const string TableName = "tb_Transport_Info";

    public TransportInfoKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }
    public byte Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public string Field9 { get; set; } = string.Empty;
    public byte Field10 { get; set; }
    public uint Field11 { get; set; }
    public byte Field12 { get; set; }
    public short Field13 { get; set; }
    public short Field14 { get; set; }
    public short Field15 { get; set; }
    public short Field16 { get; set; }
    public short Field17 { get; set; }
    public short Field18 { get; set; }
    public byte Field19 { get; set; }
    public short Field20 { get; set; }
    public short Field21 { get; set; }
    public string Field22 { get; set; } = string.Empty;

    public TransportInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadInt16();
        Field14 = reader.ReadInt16();
        Field15 = reader.ReadInt16();
        Field16 = reader.ReadInt16();
        Field17 = reader.ReadInt16();
        Field18 = reader.ReadInt16();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadInt16();
        Field21 = reader.ReadInt16();
        Field22 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<TransportInfoEntry>.TableName => TableName;

    static TransportInfoEntry IEntry<TransportInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new TransportInfoEntry(reader);
    }
}
