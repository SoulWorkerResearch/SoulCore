using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct PartyAcceptRequest
    {
        public int Character { get; }

        public PartyAcceptRequest(BinaryReader br) => Character = br.ReadInt32();
    }
}
