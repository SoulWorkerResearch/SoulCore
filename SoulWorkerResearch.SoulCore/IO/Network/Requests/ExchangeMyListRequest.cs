using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct ExchangeMyListRequest
    {
        public int Character { get; }

        public ExchangeMyListRequest(BinaryReader br) => Character = br.ReadInt32();
    }
}
