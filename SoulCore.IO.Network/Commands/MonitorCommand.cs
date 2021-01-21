namespace SoulCore.IO.Network.Commands
{
    public enum MonitorCommand : byte
    {
        SyncServerInfoAll = 0x1,
        UpdateServerInfo = 0x2,
        UpdateMazeInfo = 0x3,
        DeleteServer = 0x4,
    }
}
