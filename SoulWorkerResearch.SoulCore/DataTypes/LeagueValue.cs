using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.Extensions;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct LeagueValue
{
    public int Id { get; init; }
    public string Name { get; init; }
    public CardInfoEntity Card { get; init; }

    internal LeagueValue(BinaryReader reader)
    {
        Id = reader.ReadInt32();
        Name = reader.ReadUTF16UnicodeString();
        Card = new CardInfoEntity(reader);
    }
}
