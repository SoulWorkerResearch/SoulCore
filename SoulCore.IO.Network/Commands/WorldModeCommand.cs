using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.WorldMode)]
    public enum WorldModeCommand : byte
    {
        Start = 0x1,
        Update = 0x2,
        Finish = 0x3,
        Rank = 0x4,
        Info = 0x5,
    }
}
