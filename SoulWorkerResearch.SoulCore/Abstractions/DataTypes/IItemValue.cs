using SoulWorkerResearch.SoulCore.DataTypes;

namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface IItemOption
{
}

public interface IItemSocket
{
}

public interface IItemUpgrade
{
}

public interface IItemValue
{
    int Id { get; }
    SerialValue Serial { get; }
    ushort Count { get; }
    byte BindType { get; }
    IEnumerable<IItemOption> Options { get; }
    byte Endurance { get; }
    IEnumerable<IItemSocket> Sockets { get; }
    IItemUpgrade Upgrade { get; }
    int Attack { get; }
    int Defence { get; }
    int TitleId { get; }
    int DyeId { get; }
}
