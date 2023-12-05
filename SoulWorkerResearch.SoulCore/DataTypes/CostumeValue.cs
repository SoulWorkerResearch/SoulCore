using SoulWorkerResearch.SoulCore.DataTypes.Entities;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct CostumeValue
{
    public SerialEntity Serial { get; init; }
    public int PrototypeId { get; init; } = -1;
    public uint Color { get; init; }

    internal CostumeValue(BinaryReader reader)
    {
        Serial = new SerialEntity(reader);
        PrototypeId = reader.ReadInt32();
        Color = reader.ReadUInt32();
    }
}
