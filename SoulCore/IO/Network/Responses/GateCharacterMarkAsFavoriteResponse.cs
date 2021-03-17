using SoulCore.Types;

namespace SoulCore.IO.Network.Responses
{
    public sealed record GateCharacterMarkAsFavoriteResponse
    {
        public int AccountId { get; init; }
        public int CharacterId { get; init; }
        public Class Class { get; init; }
        public byte Level { get; init; }
        public string CharacterName { get; init; } = default!;
        public uint PhotoId { get; init; }
        public long Date { get; init; }
        public int Error { get; init; }
    }
}
