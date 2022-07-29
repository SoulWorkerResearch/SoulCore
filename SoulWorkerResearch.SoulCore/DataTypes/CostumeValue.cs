using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct CostumeValue : ICostumeValue
{
    public static CostumeValue Empty { get; } = new();

    public SerialValue Serial { get; init; }
    public int PrototypeId { get; init; } = -1;
    public uint Color { get; init; }

    internal CostumeValue(BinaryReader reader)
    {
        Serial = new(reader);
        PrototypeId = reader.ReadInt32();
        Color = reader.ReadUInt32();
    }
}
