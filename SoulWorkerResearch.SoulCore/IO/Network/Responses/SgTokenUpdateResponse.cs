namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record SgTokenUpdateResponse
    {
        public string AccessToken { get; init; } = string.Empty;
        public string RefreshToken { get; init; } = string.Empty;
        public bool Renew { get; init; }
    }
}
