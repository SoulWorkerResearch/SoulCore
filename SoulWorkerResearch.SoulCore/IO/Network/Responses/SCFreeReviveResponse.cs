namespace SoulWorkerResearch.SoulCore.IO.Network.Responses.Character
{
    public sealed record SCFreeReviveResponse
    {
        public int CharacterId { get; init; }
        public int Count { get; init; }
        public int Max { get; init; }
    }
}
