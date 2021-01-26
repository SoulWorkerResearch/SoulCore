using System.Collections.Generic;
using System.Diagnostics;

namespace SoulCore.IO.Network.Utils
{
    public static class PacketUtils
    {
        #region Constants

        private static IReadOnlyList<byte> KeyTable { get; } = new byte[]
        {
            0xEE, 0x1B, 0xDE, 0xA6, 0x46, 0xE9, 0x2A, 0xDB,
            0x97, 0x67, 0x9C, 0x02, 0x3C, 0xCE, 0x9A
        };

        #endregion Constants

        #region Encypt/Decrypt

        public static void Exchange(ref byte[] encryptedBuffer) =>
            Exchange(ref encryptedBuffer, 0x0, encryptedBuffer.Length);

        public static void Exchange(ref byte[] encryptedBuffer, int offset) =>
            Exchange(ref encryptedBuffer, offset, encryptedBuffer.Length - offset);

        public static void Exchange(ref byte[] encryptedBuffer, int offset, int size)
        {
            Debug.Assert(size > 0);
            Debug.Assert(offset >= 0);
            Debug.Assert(offset <= encryptedBuffer.Length);

            for (int i = 0; i < size; ++i)
            {
                encryptedBuffer[offset + i] ^= KeyTable[i % KeyTable.Count];
            }
        }

        public static void Exchange(byte[] encryptedBuffer, int offset, int size) =>
            Exchange(ref encryptedBuffer, offset, size);

        #endregion Encypt/Decrypt

        #region Pack

        public static byte[] Pack(PacketWriter writer)
        {
            byte[] response = writer.GetBuffer();
            PacketUtils.Exchange(ref response, Defines.PacketHeaderSize + Defines.PacketOpcodeSize, (int)writer.BaseStream.Length - (Defines.PacketHeaderSize + Defines.PacketOpcodeSize));

            return response;
        }

        #endregion Pack
    }
}