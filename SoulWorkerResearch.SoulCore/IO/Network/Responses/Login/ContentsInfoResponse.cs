using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses.Login
{
    public sealed record ContentsInfoResponse
    {
        public IEnumerable<byte> OptionBit { get; init; } = _optionBitEmpty;
        public IEnumerable<byte> Content { get; init; } = _contentEmpty;
        public int AccountId { get; init; }
        public IEnumerable<byte> KeyOption { get; init; } = _keyOptionEmpty;

        private static readonly byte[] _optionBitEmpty = new byte[64];
        private static readonly byte[] _contentEmpty = new byte[14];
        private static readonly byte[] _keyOptionEmpty = new byte[2048];
    }
}
