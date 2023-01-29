global using CashshopTabKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CashshopTabEntry : IEntry<CashshopTabEntry>
{
    public const string TableName = "tb_CashShop_Tab";

    public CashshopTabKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }

    public CashshopTabEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
    }

    static string IEntry<CashshopTabEntry>.TableName => TableName;

    static CashshopTabEntry IEntry<CashshopTabEntry>.CreateInstance(BinaryReader reader)
    {
        return new CashshopTabEntry(reader);
    }
}
