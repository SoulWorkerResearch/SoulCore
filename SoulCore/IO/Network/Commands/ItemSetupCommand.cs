﻿using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.ItemSetup)]
    public enum ItemSetupCommand : byte
    {
        Make = 0x1,
        Upgrade = 0x2,
        Exchange = 0x3,
        Disassemble = 0x4,
        SocketEquip = 0x5,
        SocketActive = 0x6,
        SocketDetach = 0x7,
        Repair = 0x8,
        RepairNpc = 0x9,
        RepairEquip = 0x10,
        RepairAll = 0x11,
        Endurance = 0x12,
        Evolution = 0x13,
        AkashicMake = 0x14,
        AkashicDisassemble = 0x15,
        UpgradeLimit = 0x16,
        AkashicCompose = 0x17,
        DisassembleEx = 0x18,
        BroachEquip = 0x20,
        BroachActive = 0x21,
        Restore = 0x22,
        BroachCompose = 0x23,
        Unseal = 0x24,
        AkashicMakeEx = 0x25,
        UseEffect = 0x26,
        Renovate = 0x27,
        BroachRemove = 0x28,
        Refine = 0x29,
        SocketExchange = 0x30,
        SocketUpgrade = 0x31,
        SocketExtract = 0x32,
        AkashicComposeEx = 0x33,
        AkashicGetinfoAdd = 0x34,
        AkashicGetinfoLoad = 0x35,
        Dye = 0x36,
        TitleChange = 0x37,
        RenovateComplete = 0x38,
        BroachRemoveEx = 0x39,
    }
}
