using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct FpValue : IFpValue
{
    public static FpValue Empty { get; } = new();

    public short Fp { get; init; }
    public short BonusFp { get; init; }
    public short PcBangFp { get; init; }

    internal FpValue(BinaryReader reader)
    {
        Fp = reader.ReadInt16();
        BonusFp = reader.ReadInt16();
        PcBangFp = reader.ReadInt16();
    }
}
