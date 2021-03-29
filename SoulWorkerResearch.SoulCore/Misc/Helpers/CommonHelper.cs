namespace SoulWorkerResearch.SoulCore.Misc.Helpers
{
    public static class CommonHelper
    {
        public static ushort MakeWord(byte a, byte b) => (ushort)(a | (b << 8));
    }
}