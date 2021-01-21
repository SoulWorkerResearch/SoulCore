using System.Numerics;

namespace SoulCore.IO.Network.Responses.Shared
{
    public sealed record SPosInfoSharedResponse
    {
        public ushort LocationId { get; init; }
        public SMapInfoSharedResponse Map { get; init; }
        public Vector3 Pos { get; init; }
        public float Rot { get; init; }

        public static SPosInfoSharedResponse Empty { get; } = new();
    }
}