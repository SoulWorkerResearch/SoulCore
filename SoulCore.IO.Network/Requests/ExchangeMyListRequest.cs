using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct ExchangeMyListRequest
    {
        public int Character { get; }

        public ExchangeMyListRequest(BinaryReader br) => Character = br.ReadInt32();
    }
}
