using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Gesture
{
    [Request(CategoryCommand.Gesture, GestureCommand.SlotUpdate)]
    public readonly struct GestureSlotUpdateRequest
    {
        public readonly IEnumerable<uint> GestureIds;

        public GestureSlotUpdateRequest(BinaryReader br) => GestureIds = Enumerable
            .Range(0, CommonDefines.QuickSlotsCount)
            .Select(id => br.ReadUInt32())
            .ToArray();
    }
}
