using SoulCore.IO.Network.Responses.Shared;
using SoulCore.Types;

namespace SoulCore.IO.Network.Responses
{
    public readonly struct DistrictEnterResponse
    {
        public DistrictConnectResult Result { get; init; }
        public MapIdPacketSharedStructure MapId { get; init; }
    }
}