using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Booster)]
    public enum BoosterCommand : byte
    {
        ListLoad = 0x1,
        Add = 0x2,
        Remove = 0x3,
        Clear = 0x4,
    }
}