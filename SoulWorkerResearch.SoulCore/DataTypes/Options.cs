using SoulWorkerResearch.SoulCore.Defines;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public sealed class Options : List<bool>
{
    public static Options Empty { get; } = new();

    public bool IsAttendanceEnabled => this[Option.Attendance];
    public bool IsSecondPasswordEnabled => this[Option.SecondPassword];
    public bool IsPvpDistrictEnabled => this[Option.PvpDistrict];
    public bool IsRankingEnabled => this[Option.Ranking];
    public bool IsCashShopEnabled => this[Option.CashShop];
    public bool IsD6ModeEnabled => this[Option.D6Mode];
    public bool IsBroachEventEnabled => this[Option.BroachEvent];
    public bool IsOverIndulgenceEnabled => this[Option.OverIndulgence];
    public bool IsSoulWeeklyMissionEnabled => this[Option.SoulWeeklyMission];
    public bool IsNetCafeEnabled => this[Option.NetCafe];
    public bool IsSoulEventEnabled => this[Option.SoulEvent];
    public bool IsItemExchangeEnabled => this[Option.ItemExchange];
    public bool IsWaitSystemEnabled => this[Option.WaitSystem];
    public bool IsOperationMazeEnabled => this[Option.OperationMaze];

    public bool this[Option index] => this[(int)index];

    public Options() : base(Enumerable.Range(0, (byte)Option.Max).Select(_ => false)) { }
}
