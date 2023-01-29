global using ResvfxKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ResvfxEntry : IEntry<ResvfxEntry>
{
    public const string TableName = "tb_ResVFX";

    public ResvfxKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public byte Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public byte Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public short Field8 { get; set; }
    public short Field9 { get; set; }
    public short Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }

    public ResvfxEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadInt16();
        Field9 = reader.ReadInt16();
        Field10 = reader.ReadInt16();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
    }

    static string IEntry<ResvfxEntry>.TableName => TableName;

    static ResvfxEntry IEntry<ResvfxEntry>.CreateInstance(BinaryReader reader)
    {
        return new ResvfxEntry(reader);
    }
}
