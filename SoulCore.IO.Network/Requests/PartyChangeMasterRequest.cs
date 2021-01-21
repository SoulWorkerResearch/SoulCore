using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct PartyChangeMasterRequest
    {
        public int Id { get; }

        public PartyChangeMasterRequest(BinaryReader br)
            => Id = br.ReadInt32();
    }
}
