using System.Numerics;
using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Net.DataTypes;

public readonly struct PositionValue
{
    public int Character { get; }
    public MapEntity Map { get; }
    public Vector3 Position { get; }
    public float Yaw { get; }
    public Vector2 TargetPosition { get; }

    internal PositionValue(BinaryReader reader)
    {
        Character = reader.ReadInt32();
        Map = new MapEntity(reader);
        Position = reader.ReadVector3();
        Yaw = reader.ReadSingle();
        TargetPosition = reader.ReadVector2();
    }
}
