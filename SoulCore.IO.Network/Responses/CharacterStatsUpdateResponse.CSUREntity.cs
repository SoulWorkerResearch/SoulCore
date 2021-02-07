using SoulCore.Types;

namespace SoulCore.IO.Network.Responses
{
    public sealed partial record CharacterStatsUpdateResponse
    {
        public sealed record CSUREntity
        {
            public StatType Id { get; init; }
            public float Value { get; init; }
        }
    }
}
