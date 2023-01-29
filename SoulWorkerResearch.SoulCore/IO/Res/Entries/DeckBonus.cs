global using DeckBonusKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DeckBonusEntry : IEntry<DeckBonusEntry>
{
    public const string TableName = "tb_Deck_Bonus";

    public DeckBonusKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public byte Field4 { get; set; }
    public float Field5 { get; set; }

    public DeckBonusEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadSingle();
    }

    static string IEntry<DeckBonusEntry>.TableName => TableName;

    static DeckBonusEntry IEntry<DeckBonusEntry>.CreateInstance(BinaryReader reader)
    {
        return new DeckBonusEntry(reader);
    }
}
