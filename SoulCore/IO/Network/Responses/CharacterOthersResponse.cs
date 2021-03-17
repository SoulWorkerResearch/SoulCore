using SoulCore.IO.Network.PacketSharedStructure;
using System.Collections.Generic;

namespace SoulCore.IO.Network.Responses
{
    public readonly struct CharacterOthersResponse
    {
        public IEnumerable<CharacterExPacketSharedStructure> Values { get; init; }
    }
}