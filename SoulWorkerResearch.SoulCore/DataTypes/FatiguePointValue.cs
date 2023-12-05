namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct FatiguePointValue 
{
    public short Value { get; init; }
    public short Extended { get; init; }
    public short Cafe { get; init; }

    internal FatiguePointValue(BinaryReader reader)
    {
        Value = reader.ReadInt16();
        Extended = reader.ReadInt16();
        Cafe = reader.ReadInt16();
    }
}
