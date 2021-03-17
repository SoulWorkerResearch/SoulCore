namespace SoulCore.IO.Network.Responses.ModeMaze
{
    public sealed partial record SRogueLikeResultInfosResponse
    {
        public readonly struct Entity
        {
            public int MapId { get; init; }
            public int ClearSectorCount { get; init; }
            public bool ClearBoss { get; init; }
            public uint ClearTime { get; init; }
        }
    }
}
