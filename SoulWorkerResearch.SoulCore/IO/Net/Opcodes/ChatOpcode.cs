using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Chat)]
public enum ChatOpcode : byte
{
    Normal = 0x1,
    Whisper = 0x2,
    Trade = 0x3,
    Notice = 0x4,

    // Notify = 0x5,
    Megaphone = 0x6,

    Memory = 0x7,

    // NoticeEx = 0x8,
    GmCommand = 0xA
}
