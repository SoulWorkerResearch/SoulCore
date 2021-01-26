using System;

namespace SoulCore.Tools.Wireshark.JsonDumpDecode
{
    public static class Messages
    {
        public static void ExtracteOpcode(byte category, byte command)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Extracted Opcode: 0x{category:X2}:{command:X2}");
        }

        public static void ProcessFrame(string id)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Process Frame: {id}");
        }

        public static void Error(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
        }
    }
}