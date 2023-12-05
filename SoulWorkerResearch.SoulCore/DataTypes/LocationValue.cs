using System.Numerics;
using SoulWorkerResearch.SoulCore.DataTypes.Entities;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct LocationValue
{
    public ushort World { get; init; }
    public MapEntity Map { get; init; }
    public Vector3 Position { get; init; }
    public float Rotation { get; init; }
}
