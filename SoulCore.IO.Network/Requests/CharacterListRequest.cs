using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct CharacterListRequest
    {
        public ulong SessionKey { get; }

        public CharacterListRequest(BinaryReader br) => SessionKey = br.ReadUInt64();
    }
}
