using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.WeeklyMission)]
    public enum WeeklyMissionCommand : byte
    {
        Info = 0x1,
        Update = 0x2,
        Reward = 0x3,
        RewardWeek = 0x4,
    }
}