using SoulWorkerResearch.SoulCore.IO.Network.Responses.Shared;
using SoulWorkerResearch.SoulCore.Types;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public readonly struct DistrictEnterResponse
    {
        public DistrictConnectResult Result { get; init; }
        public MapIdPacketSharedStructure MapId { get; init; }
    }
}
