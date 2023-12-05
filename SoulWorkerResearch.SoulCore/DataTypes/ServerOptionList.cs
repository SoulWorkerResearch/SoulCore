using SoulWorkerResearch.SoulCore.Defines;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public sealed class ServerOptionList : List<bool>
{
    public static ServerOptionList Empty => new();

    public bool IsAttendanceEnabled => this[ServerOption.Attendance];
    public bool IsSecondPasswordEnabled => this[ServerOption.SecondPassword];
    public bool IsPvpDistrictEnabled => this[ServerOption.PvpDistrict];
    public bool IsRankingEnabled => this[ServerOption.Ranking];
    public bool IsCashShopEnabled => this[ServerOption.CashShop];
    public bool IsD6ModeEnabled => this[ServerOption.D6Mode];
    public bool IsBroachEventEnabled => this[ServerOption.BroachEvent];
    public bool IsOverIndulgenceEnabled => this[ServerOption.OverIndulgence];
    public bool IsSoulWeeklyMissionEnabled => this[ServerOption.SoulWeeklyMission];
    public bool IsNetCafeEnabled => this[ServerOption.NetCafe];
    public bool IsSoulEventEnabled => this[ServerOption.SoulEvent];
    public bool IsItemExchangeEnabled => this[ServerOption.ItemExchange];
    public bool IsWaitSystemEnabled => this[ServerOption.WaitSystem];
    public bool IsOperationMazeEnabled => this[ServerOption.OperationMaze];

    public ServerOptionList() : base(Enumerable.Range(0, (byte)ServerOption.Max).Select(_ => false))
    {
    }

    public bool this[ServerOption index] => this[(int)index];
}
