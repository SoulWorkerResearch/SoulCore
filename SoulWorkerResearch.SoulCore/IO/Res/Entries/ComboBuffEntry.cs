global using ComboBuffKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ComboBuffEntry : IEntry<ComboBuffEntry>
{
    public const string TableName = "tb_Combo_Buff";

    public ComboBuffKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public byte Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public ushort Field10 { get; set; }
    public ushort Field11 { get; set; }
    public ushort Field12 { get; set; }
    public ushort Field13 { get; set; }
    public ushort Field14 { get; set; }
    public ushort Field15 { get; set; }
    public ushort Field16 { get; set; }
    public ushort Field17 { get; set; }
    public ushort Field18 { get; set; }
    public ushort Field19 { get; set; }
    public ushort Field20 { get; set; }

    public ComboBuffEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUInt16();
        Field14 = reader.ReadUInt16();
        Field15 = reader.ReadUInt16();
        Field16 = reader.ReadUInt16();
        Field17 = reader.ReadUInt16();
        Field18 = reader.ReadUInt16();
        Field19 = reader.ReadUInt16();
        Field20 = reader.ReadUInt16();
    }

    static string IEntry<ComboBuffEntry>.TableName => TableName;

    static ComboBuffEntry IEntry<ComboBuffEntry>.CreateInstance(BinaryReader reader)
    {
        return new ComboBuffEntry(reader);
    }
}
