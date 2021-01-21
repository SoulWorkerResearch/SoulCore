using SoulCore.IO.Network.Responses.Shared;

namespace SoulCore.IO.Network.Responses
{
    public sealed record SChannelBroadcastCharacterInResponse
    {
        public CharacterShared Character { get; init; } = default!;
        public PlaceShared Place { get; init; } = default!;
    }
}
