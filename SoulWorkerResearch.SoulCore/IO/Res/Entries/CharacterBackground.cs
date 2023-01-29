global using CharacterBackgroundKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CharacterBackgroundEntry : IEntry<CharacterBackgroundEntry>
{
    public const string TableName = "tb_Character_Background";

    public CharacterBackgroundKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;

    public CharacterBackgroundEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CharacterBackgroundEntry>.TableName => TableName;

    static CharacterBackgroundEntry IEntry<CharacterBackgroundEntry>.CreateInstance(BinaryReader reader)
    {
        return new CharacterBackgroundEntry(reader);
    }
}
