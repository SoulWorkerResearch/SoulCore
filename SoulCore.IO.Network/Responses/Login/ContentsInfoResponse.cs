namespace SoulCore.IO.Network.Responses.Login
{
    public sealed record ContentsInfoResponse
    {
        public byte[] OptionBit { get; init; } = _optionBitEmpty;

        public byte[] Content { get; init; } = _contentEmpty;

        public int AccountId { get; init; }
        public byte[] KeyOption { get; init; } = _keyOptionEmpty;

        private static readonly byte[] _optionBitEmpty = new byte[64];
        private static readonly byte[] _contentEmpty = new byte[14];
        private static readonly byte[] _keyOptionEmpty = new byte[2048];
    }
}