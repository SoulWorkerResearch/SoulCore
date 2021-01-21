using System.Collections.Generic;

namespace SoulCore.IO.Network.Responses
{
    public sealed record CharacterGestureLoadResponse
    {
        public IEnumerable<uint> Values { get; init; } = default!;
    }
}
