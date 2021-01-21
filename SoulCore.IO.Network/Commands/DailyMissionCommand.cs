namespace SoulCore.IO.Network.Commands
{
    public enum DailyMissionCommand : byte
    {
        List = 0x1,
        Accept = 0x2,
        Update = 0x3,
        Helper = 0x4,
        InitAll = 0x5,
    }
}
