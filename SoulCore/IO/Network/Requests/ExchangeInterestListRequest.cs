using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{

    public readonly struct ExchangeInterestListRequest
    {
        public int Character { get; }

        public ExchangeInterestListRequest(BinaryReader br) => Character = br.ReadInt32();
    }
}
