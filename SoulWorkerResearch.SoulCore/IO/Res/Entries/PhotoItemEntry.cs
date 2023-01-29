global using PhotoItemKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PhotoItemEntry : IEntry<PhotoItemEntry>
{
    public const string TableName = "tb_Photo_Item";

    public PhotoItemKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public ushort Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;
    public string Field9 { get; set; } = string.Empty;
    public string Field10 { get; set; } = string.Empty;
    public string Field11 { get; set; } = string.Empty;
    public string Field12 { get; set; } = string.Empty;
    public byte Field13 { get; set; }
    public byte Field14 { get; set; }

    public PhotoItemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadByte();
    }

    static string IEntry<PhotoItemEntry>.TableName => TableName;

    static PhotoItemEntry IEntry<PhotoItemEntry>.CreateInstance(BinaryReader reader)
    {
        return new PhotoItemEntry(reader);
    }
}
