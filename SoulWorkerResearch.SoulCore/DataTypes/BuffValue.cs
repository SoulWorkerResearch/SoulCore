using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct BuffValue : IBuffValue
{
    public static BuffValue Empty { get; } = new();

    public int Id { get; init; }
    public float Time { get; init; }
    public byte Count { get; init; }
    public uint OwnerId { get; init; }
    public byte Show { get; init; }

    internal BuffValue(BinaryReader reader)
    {
        Id = reader.ReadInt32();
        Time = reader.ReadSingle();
        Count = reader.ReadByte();
        OwnerId = reader.ReadUInt32();
        Show = reader.ReadByte();
    }
}
