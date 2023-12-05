using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.GmAgent)]
public enum GmAgentOpcode : byte
{
    UserKick = 0x1,
    NoticeMsg = 0x2,
    ShutDown = 0x3,
    TimeEvent = 0x4,
    ValueEvent = 0x5,
    ServerOption = 0x6,
    CashShopBanner = 0x7
}
