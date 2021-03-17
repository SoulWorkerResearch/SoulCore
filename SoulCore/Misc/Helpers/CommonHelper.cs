namespace SoulCore.Misc.Helpers
{
    public static class CommonHelper
    {
        public static ushort MakeWord(byte left, byte right) => (ushort)(left + (right << 8));
    }
}