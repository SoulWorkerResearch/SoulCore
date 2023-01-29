global using CreateoptionKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CreateoptionEntry : IEntry<CreateoptionEntry>
{
    public const string TableName = "tb_CreateOption";

    public CreateoptionKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public int Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public uint Field11 { get; set; }
    public byte Field12 { get; set; }
    public int Field13 { get; set; }
    public ushort Field14 { get; set; }

    public CreateoptionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadInt32();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadInt32();
        Field14 = reader.ReadUInt16();
    }

    static string IEntry<CreateoptionEntry>.TableName => TableName;

    static CreateoptionEntry IEntry<CreateoptionEntry>.CreateInstance(BinaryReader reader)
    {
        return new CreateoptionEntry(reader);
    }
}
