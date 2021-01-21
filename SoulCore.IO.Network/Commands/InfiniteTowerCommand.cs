namespace SoulCore.IO.Network.Commands
{
    public enum InfiniteTowerCommand : byte
    {
        LoadInfo = 0x1,
        EnterChapter = 0x2,
        EnterNextStage = 0x3,
        Reward = 0x4,
    }
}
