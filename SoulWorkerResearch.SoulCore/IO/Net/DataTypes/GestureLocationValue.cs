using SoulWorkerResearch.SoulCore.Extensions;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Net.DataTypes;

public readonly struct GestureLocationValue
{
    #region Body

    public Vector3 Position { get; init; }

    /// <summary>
    /// X - Yaw
    /// Y - Pitch
    /// </summary>
    public Vector2 Rotation { get; init;}

    #endregion Body

    #region Constructors

    public GestureLocationValue(BinaryReader reader)
    {
        Position = reader.ReadVector3();
        Rotation = reader.ReadVector2();
    }

    #endregion Constructors
}
