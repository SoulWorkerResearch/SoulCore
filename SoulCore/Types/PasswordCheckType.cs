namespace SoulCore.Types
{
    public enum PasswordCheckType : byte
    {
        Create = 0x1,
        Check = 0x2,
        Continue = 0x3,
        StateCheck = 0x4,
    };
}