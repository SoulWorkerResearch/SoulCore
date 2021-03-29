using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Channel)]
    public enum ChannelCommand : byte
    {
        Info = 0x1,
        Change = 0x2,
    }
}
