namespace SoulCore.IO.Network.Commands
{
    public enum ServerModeMazeCommand : byte
    {
        MatchingEnter = 0x1,
        MatchingExit = 0x3,
        MatchingWait = 0x5,
        MatchingCreateMaze = 0x6,
        MatchingTimeCheat = 0x11,
        MatchingEvent = 0x12,
    }
}
