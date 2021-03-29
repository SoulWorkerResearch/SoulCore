using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.GmAgent)]
    public enum GmAgentCommand : byte
    {
        UserKick = 0x1,
        NoticeMsg = 0x2,
        ShutDown = 0x3,
        TimeEvent = 0x4,
        ValueEvent = 0x5,
        ServerOption = 0x6,
        CashShopBanner = 0x7,
    }
}
