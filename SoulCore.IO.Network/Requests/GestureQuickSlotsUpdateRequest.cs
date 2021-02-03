using SoulCore.IO.Network.Attributes;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.IO.Network.Requests
{

    public readonly struct GestureQuickSlotsUpdateRequest
    {
        public IReadOnlyList<uint> Values { get; }

        public GestureQuickSlotsUpdateRequest(BinaryReader br) => Values = Enumerable
            .Range(0, Defines.QuickSlotsCount)
            .Select(id => br.ReadUInt32())
            .ToArray();
    }
}
