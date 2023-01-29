global using CostumeSocketKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CostumeSocketEntry : IEntry<CostumeSocketEntry>
{
    public const string TableName = "tb_Costume_Socket";

    public CostumeSocketKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public uint Field12 { get; set; }
    public ushort Field13 { get; set; }

    public CostumeSocketEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt16();
    }

    static string IEntry<CostumeSocketEntry>.TableName => TableName;

    static CostumeSocketEntry IEntry<CostumeSocketEntry>.CreateInstance(BinaryReader reader)
    {
        return new CostumeSocketEntry(reader);
    }
}
