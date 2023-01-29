global using DyeKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DyeEntry : IEntry<DyeEntry>
{
    public const string TableName = "tb_Dye";

    public DyeKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public string Field2 { get; set; } = string.Empty;
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;

    public DyeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<DyeEntry>.TableName => TableName;

    static DyeEntry IEntry<DyeEntry>.CreateInstance(BinaryReader reader)
    {
        return new DyeEntry(reader);
    }
}
