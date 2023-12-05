namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct GearValue
{
    public byte UpgradeLevel { get; init; }
    public int PrototypeId { get; init; } = -1;

    internal GearValue(BinaryReader reader)
    {
        UpgradeLevel = reader.ReadByte();
        PrototypeId = reader.ReadInt32();
    }
}
