global using PvpReviseKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PvpReviseEntry : IEntry<PvpReviseEntry>
{
    public const string TableName = "tb_PVP_Revise";

    public PvpReviseKeyType Id { get; set; }
    public short Field1 { get; set; }
    public short Field2 { get; set; }
    public short Field3 { get; set; }
    public short Field4 { get; set; }
    public short Field5 { get; set; }
    public short Field6 { get; set; }
    public short Field7 { get; set; }
    public short Field8 { get; set; }
    public short Field9 { get; set; }

    public PvpReviseEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadInt16();
        Field2 = reader.ReadInt16();
        Field3 = reader.ReadInt16();
        Field4 = reader.ReadInt16();
        Field5 = reader.ReadInt16();
        Field6 = reader.ReadInt16();
        Field7 = reader.ReadInt16();
        Field8 = reader.ReadInt16();
        Field9 = reader.ReadInt16();
    }

    static string IEntry<PvpReviseEntry>.TableName => TableName;

    static PvpReviseEntry IEntry<PvpReviseEntry>.CreateInstance(BinaryReader reader)
    {
        return new PvpReviseEntry(reader);
    }
}
