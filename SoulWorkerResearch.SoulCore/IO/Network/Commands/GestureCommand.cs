using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Gesture)]
    public enum GestureCommand : byte
    {
        Show = 0x1,
        SlotLoad = 0x2,
        SlotUpdate = 0x3,
    }
}
