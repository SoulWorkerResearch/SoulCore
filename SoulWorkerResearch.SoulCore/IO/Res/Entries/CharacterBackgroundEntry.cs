global using CharacterBackgroundKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record CharacterBackgroundEntry : ITableEntry<CharacterBackgroundKeyType>
{
    public const string TableName = "tb_Character_Background";

    public CharacterBackgroundKeyType Id { get; }
    public ushort Unknown1 { get; }
    public ushort Unknown2 { get; }
    public ushort Unknown3 { get; }
    public string Unknown4 { get; }

    public CharacterBackgroundEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Unknown1 = reader.ReadUInt16();
        Unknown2 = reader.ReadUInt16();
        Unknown3 = reader.ReadUInt16();
        Unknown4 = reader.ReadUTF16UnicodeString();
    }
}
