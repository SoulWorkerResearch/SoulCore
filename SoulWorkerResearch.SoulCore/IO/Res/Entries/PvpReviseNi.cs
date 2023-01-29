global using PvpReviseNiKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PvpReviseNiEntry : IEntry<PvpReviseNiEntry>
{
    public const string TableName = "tb_PVP_Revise_NI";

    public PvpReviseNiKeyType Id { get; set; }
    public int Field1 { get; set; }
    public int Field2 { get; set; }
    public short Field3 { get; set; }
    public short Field4 { get; set; }
    public short Field5 { get; set; }
    public short Field6 { get; set; }
    public short Field7 { get; set; }
    public short Field8 { get; set; }
    public int Field9 { get; set; }
    public short Field10 { get; set; }
    public short Field11 { get; set; }

    public PvpReviseNiEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadInt32();
        Field2 = reader.ReadInt32();
        Field3 = reader.ReadInt16();
        Field4 = reader.ReadInt16();
        Field5 = reader.ReadInt16();
        Field6 = reader.ReadInt16();
        Field7 = reader.ReadInt16();
        Field8 = reader.ReadInt16();
        Field9 = reader.ReadInt32();
        Field10 = reader.ReadInt16();
        Field11 = reader.ReadInt16();
    }

    static string IEntry<PvpReviseNiEntry>.TableName => TableName;

    static PvpReviseNiEntry IEntry<PvpReviseNiEntry>.CreateInstance(BinaryReader reader)
    {
        return new PvpReviseNiEntry(reader);
    }
}
