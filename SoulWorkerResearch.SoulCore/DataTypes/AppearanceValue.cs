using SoulWorkerResearch.SoulCore.DataTypes.Entities;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct AppearanceValue(BinaryReader reader)
{
    public ushort Face { get; init; } = reader.ReadUInt16();
    public EntityValue Shape { get; init; } = new EntityValue(reader);
    public EntityValue Look { get; init; } = new EntityValue(reader);

    public readonly struct EntityValue(BinaryReader reader)
    {
        public HairEntity Hair { get; init; } = new HairEntity(reader);
        public ushort EyeColor { get; init; } = reader.ReadUInt16();
        public ushort SkinColor { get; init; } = reader.ReadUInt16();
    }
}
