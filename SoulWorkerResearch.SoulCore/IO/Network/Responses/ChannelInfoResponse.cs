using SoulWorkerResearch.SoulCore.Types;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record ChannelInfoResponse
    {
        public readonly struct Entity
        {
            public ushort Id { get; init; }
            public ChannelLoadStatus Status { get; init; }
        }

        public ushort Location { get; init; }
        public IEnumerable<Entity> Values { get; init; } = default!;
    }
}
