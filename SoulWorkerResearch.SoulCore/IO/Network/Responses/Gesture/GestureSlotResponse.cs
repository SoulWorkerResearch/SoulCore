using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    [Response(CategoryCommand.Gesture, GestureCommand.SlotUpdate)]
    [Response(CategoryCommand.Gesture, GestureCommand.SlotLoad)]
    public readonly struct GestureSlotResponse
    {
        public IEnumerable<uint> GestureIds { get; init; }
    }
}
