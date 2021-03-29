using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Ranking)]
    public enum RankingCommand : byte
    {
        List = 0x1,
        Reward = 0x2,
    }
}
