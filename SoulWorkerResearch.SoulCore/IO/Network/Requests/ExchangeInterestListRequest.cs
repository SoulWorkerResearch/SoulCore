using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct ExchangeInterestListRequest
    {
        public int Character { get; }

        public ExchangeInterestListRequest(BinaryReader br) => Character = br.ReadInt32();
    }
}
