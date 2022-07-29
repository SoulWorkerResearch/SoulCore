namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface ILeagueValue
{
    int Id { get; }
    string Name { get; }
    ICardInfo Card { get; }
}
