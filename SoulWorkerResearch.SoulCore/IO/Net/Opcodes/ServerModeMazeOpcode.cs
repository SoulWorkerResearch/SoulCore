using SoulWorkerResearch.SoulCore.IO.Net.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

[OpcodeGroup(GroupOpcode.ServerModeMaze)]
public enum ServerModeMazeOpcode : byte
{
    MatchingEnter = 0x1,
    MatchingExit = 0x3,
    MatchingWait = 0x5,
    MatchingCreateMaze = 0x6,
    MatchingTimeCheat = 0x11,
    MatchingEvent = 0x12
}
