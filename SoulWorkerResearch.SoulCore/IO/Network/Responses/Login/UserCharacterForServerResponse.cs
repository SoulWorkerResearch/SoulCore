using System;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed partial record UserCharacterForServerResponse
    {
        public byte LastSelectedId { get; init; }
        public IEnumerable<Entity> Values { get; init; } = Array.Empty<Entity>();
    }
}
