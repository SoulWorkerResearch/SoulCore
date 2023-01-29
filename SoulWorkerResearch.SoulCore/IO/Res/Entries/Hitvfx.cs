global using HitvfxKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class HitvfxEntry : IEntry<HitvfxEntry>
{
    public const string TableName = "tb_HitVFX";

    public HitvfxKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public string Field8 { get; set; } = string.Empty;
    public string Field9 { get; set; } = string.Empty;
    public string Field10 { get; set; } = string.Empty;
    public string Field11 { get; set; } = string.Empty;
    public string Field12 { get; set; } = string.Empty;
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;

    public HitvfxEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUTF16UnicodeString();
        Field11 = reader.ReadUTF16UnicodeString();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<HitvfxEntry>.TableName => TableName;

    static HitvfxEntry IEntry<HitvfxEntry>.CreateInstance(BinaryReader reader)
    {
        return new HitvfxEntry(reader);
    }
}
