using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.DailyMission)]
    public enum DailyMissionCommand : byte
    {
        List = 0x1,
        Accept = 0x2,
        Update = 0x3,
        Helper = 0x4,
        InitAll = 0x5,
    }
}
