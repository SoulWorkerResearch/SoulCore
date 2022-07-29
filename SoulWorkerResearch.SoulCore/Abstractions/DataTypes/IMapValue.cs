namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface IMapValue
{
    byte ChannelId { get; }
    ushort MapId { get; }
    ushort ServerId { get; }
}
