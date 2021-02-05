using SoulCore.IO.Network.PacketSharedStructure;
using SoulCore.IO.Network.Responses.Shared;

namespace SoulCore.IO.Network.Responses
{
    public record CharacterInfoResponse
    {
        public CharacterPacketSharedStructure Character { get; init; } = default!;
        public PlaceShared Place { get; init; } = default!;
        public CharacterInfoResult Result { get; init; } = CharacterInfoResult.Positive;
    }
}
