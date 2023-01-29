global using DiceEpisodeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DiceEpisodeEntry : IEntry<DiceEpisodeEntry>
{
    public const string TableName = "tb_Dice_Episode";

    public DiceEpisodeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public ushort Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public uint Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;

    public DiceEpisodeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<DiceEpisodeEntry>.TableName => TableName;

    static DiceEpisodeEntry IEntry<DiceEpisodeEntry>.CreateInstance(BinaryReader reader)
    {
        return new DiceEpisodeEntry(reader);
    }
}
