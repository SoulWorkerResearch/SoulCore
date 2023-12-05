namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct BuffValue(BinaryReader reader)
{
    public int Id { get; init; } = reader.ReadInt32();
    public float Time { get; init; } = reader.ReadSingle();
    public byte Count { get; init; } = reader.ReadByte();
    public uint OwnerId { get; init; } = reader.ReadUInt32();
    public byte Show { get; init; } = reader.ReadByte();
}
