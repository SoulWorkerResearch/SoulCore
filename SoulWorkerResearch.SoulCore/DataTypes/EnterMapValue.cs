using SoulWorkerResearch.SoulCore.DataTypes.Enums;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct EnterMapValue
{
    public MapChangeType ChangeType { get; init; }
    public bool ChangeServer { get; init; }
    public EnterMapResult Result { get; init; }
    public PartyDataValue PartyInfo { get; init; }
}
