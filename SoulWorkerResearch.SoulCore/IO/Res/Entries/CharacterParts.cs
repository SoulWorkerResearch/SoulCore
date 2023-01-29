global using CharacterPartsKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CharacterPartsEntry : IEntry<CharacterPartsEntry>
{
    public const string TableName = "tb_Character_Parts";

    public CharacterPartsKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public string Field6 { get; set; } = string.Empty;
    public string Field7 { get; set; } = string.Empty;

    public CharacterPartsEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CharacterPartsEntry>.TableName => TableName;

    static CharacterPartsEntry IEntry<CharacterPartsEntry>.CreateInstance(BinaryReader reader)
    {
        return new CharacterPartsEntry(reader);
    }
}
