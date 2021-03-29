using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Drop)]
    public enum DropCommand : byte
    {
        Infos = 0x1,
        PickUp = 0x2,
        Delete = 0x3,
    }
}
