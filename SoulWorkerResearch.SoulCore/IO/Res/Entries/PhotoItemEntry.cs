global using PhotoItemKeyType = System.UInt32;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record PhotoItemEntry : ITableEntry<PhotoItemKeyType>
{
    public const string TableName = "tb_Photo_Item";

    public PhotoItemKeyType Id { get; }
    public uint Unknown1 { get; }
    public ushort Unknown2 { get; }
    public string Unknown3 { get; }
    public string Unknown4 { get; }
    public string Unknown5 { get; }
    public string Unknown6 { get; }
    public string Unknown7 { get; }
    public string Unknown8 { get; }
    public string Unknown9 { get; }
    public string Unknown10 { get; }
    public string Unknown11 { get; }
    public string Unknown12 { get; }
    public CustomizeEyesKeyType Class { get; }
    public byte PromotionInfo { get; }

    public PhotoItemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Unknown1 = reader.ReadUInt32();
        Unknown2 = reader.ReadUInt16();
        Unknown3 = reader.ReadUTF16UnicodeString();
        Unknown4 = reader.ReadUTF16UnicodeString();
        Unknown5 = reader.ReadUTF16UnicodeString();
        Unknown6 = reader.ReadUTF16UnicodeString();
        Unknown7 = reader.ReadUTF16UnicodeString();
        Unknown8 = reader.ReadUTF16UnicodeString();
        Unknown9 = reader.ReadUTF16UnicodeString();
        Unknown10 = reader.ReadUTF16UnicodeString();
        Unknown11 = reader.ReadUTF16UnicodeString();
        Unknown12 = reader.ReadUTF16UnicodeString();
        Class = reader.ReadClass();
        PromotionInfo = reader.ReadByte();
    }
}
