using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct SCharacterDeleteRequest
    {
        public int Id { get; }

        public SCharacterDeleteRequest(BinaryReader br) => Id = br.ReadInt32();
    }
}
