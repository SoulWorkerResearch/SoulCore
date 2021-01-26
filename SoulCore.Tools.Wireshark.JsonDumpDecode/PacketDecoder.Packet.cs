using System;

namespace SoulCore.Tools.Wireshark.JsonDumpDecode
{
    public sealed partial class PacketDecoder
    {
        public sealed record Packet
        {
            public ulong Frame { get; init; }
            public string Time { get; init; } = string.Empty;
            public string Sender { get; init; } = string.Empty;
            public string Receiver { get; init; } = string.Empty;
            public byte[] Body { get; init; } = Array.Empty<byte>();
        }
    }
}