using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.Monitor)]
public enum MonitorOpcode : byte
{
    SyncServerInfoAll = 0x1,
    UpdateServerInfo = 0x2,
    UpdateMazeInfo = 0x3,
    DeleteServer = 0x4,
}
