using SoulWorkerResearch.SoulCore.DataTypes;

namespace SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

public interface ICostumeValue
{
    SerialValue Serial { get; }
    int PrototypeId { get; }
    uint Color { get; }
}
