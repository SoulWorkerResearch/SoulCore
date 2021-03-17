using SoulCore.Types;
using SoulCore.IO.Network.Responses.Shared;

namespace SoulCore.IO.Network.Responses
{
    public sealed record DistrictLogOutResponse : SEndPointSharedResponse
    {
        public int Account { get; init; }
        public int Character { get; init; }
        public DistrictLogOutWay Way { get; init; } = DistrictLogOutWay.GoToGateService;
        public DistrictLogOutStatus Status { get; init; } = DistrictLogOutStatus.Success;
    }
}
