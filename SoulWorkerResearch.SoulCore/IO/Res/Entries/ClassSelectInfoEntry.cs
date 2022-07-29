global using ClassSelectInfoKeyType = SoulWorkerResearch.SoulCore.Defines.Class;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record ClassSelectInfoEntry : ITableEntry<ClassSelectInfoKeyType>
{
    public const string TableName = "tb_ClassSelect_Info";

    public ClassSelectInfoKeyType Id { get; }
    public string Unknown5 { get; }
    public string Unknown6 { get; }
    public uint Unknown7 { get; }
    public uint Unknown8 { get; }
    public uint Unknown9 { get; }
    public uint Unknown10 { get; }
    public uint Unknown11 { get; }
    public uint HandsFashionId { get; }
    public uint Unknown13 { get; }
    public uint OuterwearFashionId { get; }
    public uint Unknown15 { get; }
    public uint StockingsFashionId { get; }
    public uint ShoesFashionId { get; }
    public uint Unknown18 { get; }
    public uint Unknown19 { get; }
    public ushort Unknown20 { get; }
    public ushort Unknown21 { get; }
    public int Unknown22 { get; }
    public ushort Unknown23 { get; }
    public string Unknown24 { get; }
    public string Unknown25 { get; }
    public string Unknown26 { get; }
    public string Unknown27 { get; }
    public string Unknown28 { get; }
    public string Unknown29 { get; }

    public ClassSelectInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadClass();
        Unknown5 = reader.ReadUTF16UnicodeString();
        Unknown6 = reader.ReadUTF16UnicodeString();
        Unknown7 = reader.ReadUInt32();
        Unknown8 = reader.ReadUInt32();
        Unknown9 = reader.ReadUInt32();
        Unknown10 = reader.ReadUInt32();
        Unknown11 = reader.ReadUInt32();
        HandsFashionId = reader.ReadUInt32();
        Unknown13 = reader.ReadUInt32();
        OuterwearFashionId = reader.ReadUInt32();
        Unknown15 = reader.ReadUInt32();
        StockingsFashionId = reader.ReadUInt32();
        ShoesFashionId = reader.ReadUInt32();
        Unknown18 = reader.ReadUInt32();
        Unknown19 = reader.ReadUInt32();
        Unknown20 = reader.ReadUInt16();
        Unknown21 = reader.ReadUInt16();
        Unknown22 = reader.ReadInt32();
        Unknown23 = reader.ReadUInt16();
        Unknown24 = reader.ReadUTF16UnicodeString();
        Unknown25 = reader.ReadUTF16UnicodeString();
        Unknown26 = reader.ReadUTF16UnicodeString();
        Unknown27 = reader.ReadUTF16UnicodeString();
        Unknown28 = reader.ReadUTF16UnicodeString();
        Unknown29 = reader.ReadUTF16UnicodeString();
    }
}
