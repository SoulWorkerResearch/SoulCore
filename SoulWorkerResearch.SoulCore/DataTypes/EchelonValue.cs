using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct EchelonValue : IEchelonValue
{
    public static EchelonValue Empty { get; } = new();

    public byte Level { get; init; }
    public int Exp { get; init; }

    internal EchelonValue(BinaryReader reader)
    {
        Level = reader.ReadByte();
        Exp = reader.ReadInt32();
    }
}
