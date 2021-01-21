﻿namespace SoulCore.Utils
{
    public static class ConvertUtils
    {
        public static ushort LeToBeUInt16(ushort value) =>
            (ushort)((ushort)((value & 0xFF) << 8) | (value >> 8 & 0xFF));

        public static ushort MakeWord(byte a, byte b) =>
            (ushort)(a | b << 8);
    }
}