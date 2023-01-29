global using CreditRaiseKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CreditRaiseEntry : IEntry<CreditRaiseEntry>
{
    public const string TableName = "tb_Credit_Raise";

    public CreditRaiseKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }

    public CreditRaiseEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
    }

    static string IEntry<CreditRaiseEntry>.TableName => TableName;

    static CreditRaiseEntry IEntry<CreditRaiseEntry>.CreateInstance(BinaryReader reader)
    {
        return new CreditRaiseEntry(reader);
    }
}
