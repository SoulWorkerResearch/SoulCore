global using PvpRoleKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PvpRoleEntry : IEntry<PvpRoleEntry>
{
    public const string TableName = "tb_PvP_Role";

    public PvpRoleKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public int Field13 { get; set; }
    public byte Field14 { get; set; }
    public int Field15 { get; set; }
    public int Field16 { get; set; }
    public byte Field17 { get; set; }
    public int Field18 { get; set; }
    public int Field19 { get; set; }
    public byte Field20 { get; set; }
    public byte Field21 { get; set; }
    public byte Field22 { get; set; }
    public int Field23 { get; set; }
    public int Field24 { get; set; }

    public PvpRoleEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadInt32();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadInt32();
        Field16 = reader.ReadInt32();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadInt32();
        Field19 = reader.ReadInt32();
        Field20 = reader.ReadByte();
        Field21 = reader.ReadByte();
        Field22 = reader.ReadByte();
        Field23 = reader.ReadInt32();
        Field24 = reader.ReadInt32();
    }

    static string IEntry<PvpRoleEntry>.TableName => TableName;

    static PvpRoleEntry IEntry<PvpRoleEntry>.CreateInstance(BinaryReader reader)
    {
        return new PvpRoleEntry(reader);
    }
}
