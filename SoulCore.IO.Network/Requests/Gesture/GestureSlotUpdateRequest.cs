using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.IO.Network.Requests.Gesture
{
    [Request(CategoryCommand.Gesture, GestureCommand.SlotUpdate)]
    public readonly struct GestureSlotUpdateRequest
    {
        public readonly IEnumerable<uint> GestureIds;

        public GestureSlotUpdateRequest(BinaryReader br) => GestureIds = Enumerable
            .Range(0, Defines.QuickSlotsCount)
            .Select(id => br.ReadUInt32())
            .ToArray();
    }
}