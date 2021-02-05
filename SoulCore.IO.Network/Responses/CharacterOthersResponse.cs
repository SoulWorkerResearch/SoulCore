using SoulCore.IO.Network.PacketSharedStructure;
using SoulCore.IO.Network.Responses.Shared;
using System.Collections.Generic;

namespace SoulCore.IO.Network.Responses
{
    public sealed record CharacterOthersResponse
    {
        public readonly struct Entity
        {
            public CharacterPacketSharedStructure Character { get; init; }
            public PlaceShared Place { get; init; }
        }

        public IEnumerable<Entity> Values { get; init; } = default!;
    }
}
