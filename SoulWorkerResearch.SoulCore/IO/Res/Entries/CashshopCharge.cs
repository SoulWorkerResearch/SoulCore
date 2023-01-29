global using CashshopChargeKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CashshopChargeEntry : IEntry<CashshopChargeEntry>
{
    public const string TableName = "tb_CashShop_Charge";

    public CashshopChargeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }

    public CashshopChargeEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
    }

    static string IEntry<CashshopChargeEntry>.TableName => TableName;

    static CashshopChargeEntry IEntry<CashshopChargeEntry>.CreateInstance(BinaryReader reader)
    {
        return new CashshopChargeEntry(reader);
    }
}
