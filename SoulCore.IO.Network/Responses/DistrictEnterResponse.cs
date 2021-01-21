using SoulCore.Types;
using SoulCore.IO.Network.Responses.Shared;

namespace SoulCore.IO.Network.Responses
{
    public sealed record DistrictEnterResponse
    {
        public DistrictConnectResult Result { get; init; } = DistrictConnectResult.Yes;
        public PlaceShared Place { get; init; } = default!;
    }
}
