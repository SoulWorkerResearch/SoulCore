using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.ItemUpgrade)]
    public enum ItemUpgradeCommand : byte
    {
        Ok = 0x1,
        AddOptionOk = 0x2,
        MixOptionOk = 0x3,
    }
}
