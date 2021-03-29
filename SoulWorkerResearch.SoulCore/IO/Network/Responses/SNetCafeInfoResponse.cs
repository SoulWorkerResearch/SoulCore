namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record SNetCafeInfoResponse
    {
        public bool NetCafe { get; init; }
        public int Event { get; init; }
    }
}
