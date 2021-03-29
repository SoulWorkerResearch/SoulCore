using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.InfiniteTower)]
    public enum InfiniteTowerCommand : byte
    {
        LoadInfo = 0x1,
        EnterChapter = 0x2,
        EnterNextStage = 0x3,
        Reward = 0x4,
    }
}
