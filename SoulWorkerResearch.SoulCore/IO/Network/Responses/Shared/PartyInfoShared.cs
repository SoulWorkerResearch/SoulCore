namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record PartyInfoShared
    {
        public int Id { get; init; }
        public byte GroupType { get; init; }

        public static PartyInfoShared Empty { get; } = new();
    }
}
