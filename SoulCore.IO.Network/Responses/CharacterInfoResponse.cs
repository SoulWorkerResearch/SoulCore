using SoulCore.IO.Network.Responses.Shared;

namespace SoulCore.IO.Network.Responses
{
    public record CharacterInfoResponse
    {
        public CharacterShared Character { get; init; } = default!;
        public PlaceShared Place { get; init; } = default!;
        public CharacterInfoResult Result { get; init; } = CharacterInfoResult.Positive;
    }
}
