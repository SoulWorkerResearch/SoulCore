using SoulWorkerResearch.SoulCore.Types;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record GateEnterResponse
    {
        public int AccountId { get; init; }
        public GateEnterResult Result { get; init; }
    }
}
