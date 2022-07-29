using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using SoulWorkerResearch.SoulCore.Extensions;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct LeagueValue : ILeagueValue
{
    public static LeagueValue Empty { get; } = new();

    public int Id { get; init; }
    public string Name { get; init; }
    public CardInfo Card { get; init; }

    #region ILeagueValue

    ICardInfo ILeagueValue.Card => Card;

    #endregion ILeagueValue

    internal LeagueValue(BinaryReader reader)
    {
        Id = reader.ReadInt32();
        Name = reader.ReadUTF16UnicodeString();
        Card = new(reader);
    }
}
