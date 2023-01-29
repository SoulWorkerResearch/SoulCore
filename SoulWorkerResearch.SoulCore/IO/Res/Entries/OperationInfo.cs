global using OperationInfoKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class OperationInfoEntry : IEntry<OperationInfoEntry>
{
    public const string TableName = "tb_Operation_Info";

    public OperationInfoKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public int Field5 { get; set; }
    public int Field6 { get; set; }
    public int Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public int Field10 { get; set; }
    public int Field11 { get; set; }
    public int Field12 { get; set; }
    public int Field13 { get; set; }
    public int Field14 { get; set; }
    public int Field15 { get; set; }
    public string Field16 { get; set; } = string.Empty;
    public int Field17 { get; set; }
    public int Field18 { get; set; }
    public int Field19 { get; set; }
    public int Field20 { get; set; }
    public int Field21 { get; set; }
    public int Field22 { get; set; }
    public int Field23 { get; set; }
    public int Field24 { get; set; }
    public int Field25 { get; set; }
    public int Field26 { get; set; }
    public int Field27 { get; set; }
    public int Field28 { get; set; }
    public int Field29 { get; set; }
    public int Field30 { get; set; }
    public int Field31 { get; set; }
    public int Field32 { get; set; }
    public ushort Field33 { get; set; }
    public ushort Field34 { get; set; }
    public ushort Field35 { get; set; }
    public uint Field36 { get; set; }
    public uint Field37 { get; set; }

    public OperationInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadInt32();
        Field6 = reader.ReadInt32();
        Field7 = reader.ReadInt32();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadInt32();
        Field11 = reader.ReadInt32();
        Field12 = reader.ReadInt32();
        Field13 = reader.ReadInt32();
        Field14 = reader.ReadInt32();
        Field15 = reader.ReadInt32();
        Field16 = reader.ReadUTF16UnicodeString();
        Field17 = reader.ReadInt32();
        Field18 = reader.ReadInt32();
        Field19 = reader.ReadInt32();
        Field20 = reader.ReadInt32();
        Field21 = reader.ReadInt32();
        Field22 = reader.ReadInt32();
        Field23 = reader.ReadInt32();
        Field24 = reader.ReadInt32();
        Field25 = reader.ReadInt32();
        Field26 = reader.ReadInt32();
        Field27 = reader.ReadInt32();
        Field28 = reader.ReadInt32();
        Field29 = reader.ReadInt32();
        Field30 = reader.ReadInt32();
        Field31 = reader.ReadInt32();
        Field32 = reader.ReadInt32();
        Field33 = reader.ReadUInt16();
        Field34 = reader.ReadUInt16();
        Field35 = reader.ReadUInt16();
        Field36 = reader.ReadUInt32();
        Field37 = reader.ReadUInt32();
    }

    static string IEntry<OperationInfoEntry>.TableName => TableName;

    static OperationInfoEntry IEntry<OperationInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new OperationInfoEntry(reader);
    }
}
