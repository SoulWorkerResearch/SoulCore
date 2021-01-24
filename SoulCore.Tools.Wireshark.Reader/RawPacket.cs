using System;

namespace SoulCore.Tools.Wireshark.Reader
{
    public sealed record RawPacket
    {
        public string Frame { get; init; } = string.Empty;
        public string RelativeTime { get; init; } = string.Empty;
        public string SrcIp { get; init; } = string.Empty;
        public string DstIp { get; init; } = string.Empty;
        public byte[] Payload { get; init; } = Array.Empty<byte>();
    }
}