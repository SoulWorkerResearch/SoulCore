using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record CharacterPostInfoResponse
    {
        public IEnumerable<object> Values { get; init; } = default!;
    }
}
