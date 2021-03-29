using SoulWorkerResearch.SoulCore.IO.Network.PacketSharedStructure;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record GateCharacterListResponse
    {
        public IReadOnlyList<CharacterPacketSharedStructure> Characters { get; init; } = default!;
        public ulong InitializeTime { get; init; }
        public int LastSelected { get; init; }
    }
}
