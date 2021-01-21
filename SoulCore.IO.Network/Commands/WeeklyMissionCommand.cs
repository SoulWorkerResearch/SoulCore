namespace SoulCore.IO.Network.Commands
{
    public enum WeeklyMissionCommand : byte
    {
        Info = 0x1,
        Update = 0x2,
        Reward = 0x3,
        RewardWeek = 0x4,
    }
}
