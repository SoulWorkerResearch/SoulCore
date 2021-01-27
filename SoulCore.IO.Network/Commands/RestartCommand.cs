using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Restart)]
    public enum RestartCommand : byte
    {
        Update = 0x1,
        Start = 0x2,
    }
}