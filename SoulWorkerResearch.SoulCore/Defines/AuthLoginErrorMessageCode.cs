namespace SoulWorkerResearch.SoulCore.Defines;

public enum AuthLoginErrorMessageCode : uint
{
    None = 0,
    WrongUsernameOrPassword = 1,
    InGameAlready = 2,
    BlockAccountId = 3,
    BlockMac = 5,
    WrongMac = 6,
    CheckSystem = 7
}
