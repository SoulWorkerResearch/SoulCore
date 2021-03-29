using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.SoulMetry)]
    public enum SoulMetryCommand : byte
    {
        List = 0x1,
        CompleteList = 0x2,
        Add = 0x3,
        Update = 0x4,
        Complete = 0x5,
        Reset = 0x6,
    }
}
